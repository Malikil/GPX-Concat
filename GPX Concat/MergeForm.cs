using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GPX_Concat.Lib;

namespace GPX_Concat
{
    public partial class MergeForm : Form
    {
        private GPX gpx1, gpx2;
        private readonly Dictionary<string, Action<string>> saveButtonMap;

        public MergeForm()
        {
            InitializeComponent();

            saveButtonMap = new Dictionary<string, Action<string>>
            {
                { "concat", SaveConcat },
                { "tiles", SaveTileGrid }
            };
        }

        private void OpenFileHandler(object sender, EventArgs e)
        {
            // Show the file selection window
            var openResult = openFileDialog.ShowDialog();
            if (openResult == DialogResult.Cancel ||
                    !File.Exists(openFileDialog.FileName))
                return;

            // Open the selected file
            GPX gpx = GPX.ReadFile(openFileDialog.FileName);

            // Store into the proper variable and show the filename
            if (sender == selectGpx1Button)
            {
                gpx1Textbox.Text = gpx.Name;
                gpx1 = gpx;
            }
            else // GPX 2
            {
                gpx2Textbox.Text = gpx.Name;
                gpx2 = gpx;
            }

            // Clean up the filename box for the user
            openFileDialog.FileName = Path.GetFileName(openFileDialog.FileName);
        }

        private void SaveFileHandler(object sender, EventArgs e)
        {
            var saveResult = saveFileDialog.ShowDialog();
            if (saveResult == DialogResult.Cancel)
                return;

            // The save button functionality changes depending on the selected tab
            saveButtonMap[tabControl.SelectedTab.Tag as string](saveFileDialog.FileName);
        }

        private void SaveConcat(string filename)
        {
            string trackname = Path.GetFileNameWithoutExtension(filename);

            var concat = new GPX() { Name = trackname };
            concat.Append(gpx1);
            concat.Append(gpx2);
            concat.WriteFile(filename);

            // Ask if there are more files to merge
            var more = MessageBox.Show("Would you like to append another file?", "GPX Saved", MessageBoxButtons.YesNo);
            if (more == DialogResult.Yes)
            {
                // Move the new gpx up to slot 1
                gpx1 = concat;
                gpx1Textbox.Text = gpx1.Name;
                // Show the open file dialog
                selectGpx2Button.PerformClick();

                // Clean up the save dialog filename for the user
                saveFileDialog.FileName = trackname + ".gpx";
            }
            else
                exitButton.PerformClick();
        }

        private void SaveTileGrid(string filename)
        {
            var waypoints = new GPX();

            // Get the input latlon
            if (!double.TryParse(latBox.Text, out double lat) || !double.TryParse(lonBox.Text, out double lon))
            {
                MessageBox.Show("Enter both latitude and longitude", "Value");
                return;
            }

            var gridPoints = new HashSet<LatLon>();
            var startingTile = TileCalculator.Tile(lat, lon);
            for (int i = 0; i < gridRadiusEntry.Value; i++)
            {
                for (int row = -1; row <= 1; row++)
                for (int col = -1; col <= 1; col++)
                foreach (var pt in TileCalculator.Corners(startingTile.X + row * i, startingTile.Y + col * i))
                    gridPoints.Add(pt);
            }

            foreach (var point in gridPoints)
            {
                var wpt = new Wpt
                {
                    Lat = point.Lat,
                    Lon = point.Lon,
                    Name = "Tile Corner",
                    Sym = "City (Small)"
                };
                waypoints.AddWaypoint(wpt);
            }

            waypoints.WriteFile(filename);
            MessageBox.Show($"Wrote {gridPoints.Count} points");
        }

        private void CalculatePointCount(object sender, EventArgs e)
        {
            // Calculate and display the new number of generated points
            int points = (int)gridRadiusEntry.Value * 2;
            points *= points;

            // Update label
            waypointCountResultLabel.Text = $"{points} points";
        }

        private void ExitButton(object sender, EventArgs e) { Close(); }
    }
}
