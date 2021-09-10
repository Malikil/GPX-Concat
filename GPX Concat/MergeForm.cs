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

namespace GPX_Concat
{
    public partial class MergeForm : Form
    {
        private GPX gpx1, gpx2;

        public MergeForm()
        {
            InitializeComponent();
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

            string filename = saveFileDialog.FileName;
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

        private void ExitButton(object sender, EventArgs e) { Close(); }
    }
}
