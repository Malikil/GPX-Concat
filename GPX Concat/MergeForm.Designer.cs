
namespace GPX_Concat
{
    partial class MergeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeForm));
            this.concatTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.gpx1Label = new System.Windows.Forms.Label();
            this.gpx1Textbox = new System.Windows.Forms.TextBox();
            this.gpx2Label = new System.Windows.Forms.Label();
            this.gpx2Textbox = new System.Windows.Forms.TextBox();
            this.selectGpx1Button = new System.Windows.Forms.Button();
            this.selectGpx2Button = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.concatTab = new System.Windows.Forms.TabPage();
            this.tileGridTab = new System.Windows.Forms.TabPage();
            this.tileGridTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.latLonLabel = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.gridCountLabel = new System.Windows.Forms.Label();
            this.gridRadiusEntry = new System.Windows.Forms.NumericUpDown();
            this.waypointCountResultLabel = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.concatTableLayout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.concatTab.SuspendLayout();
            this.tileGridTab.SuspendLayout();
            this.tileGridTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRadiusEntry)).BeginInit();
            this.mainTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // concatTableLayout
            // 
            this.concatTableLayout.ColumnCount = 4;
            this.concatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.concatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.concatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.concatTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.concatTableLayout.Controls.Add(this.gpx1Label, 0, 0);
            this.concatTableLayout.Controls.Add(this.gpx1Textbox, 1, 0);
            this.concatTableLayout.Controls.Add(this.gpx2Label, 0, 1);
            this.concatTableLayout.Controls.Add(this.gpx2Textbox, 1, 1);
            this.concatTableLayout.Controls.Add(this.selectGpx1Button, 3, 0);
            this.concatTableLayout.Controls.Add(this.selectGpx2Button, 3, 1);
            this.concatTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.concatTableLayout.Location = new System.Drawing.Point(3, 3);
            this.concatTableLayout.Name = "concatTableLayout";
            this.concatTableLayout.RowCount = 2;
            this.concatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.concatTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.concatTableLayout.Size = new System.Drawing.Size(232, 70);
            this.concatTableLayout.TabIndex = 0;
            // 
            // gpx1Label
            // 
            this.gpx1Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpx1Label.AutoSize = true;
            this.gpx1Label.Location = new System.Drawing.Point(3, 11);
            this.gpx1Label.Name = "gpx1Label";
            this.gpx1Label.Size = new System.Drawing.Size(41, 13);
            this.gpx1Label.TabIndex = 0;
            this.gpx1Label.Text = "GPX 1:";
            // 
            // gpx1Textbox
            // 
            this.gpx1Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.concatTableLayout.SetColumnSpan(this.gpx1Textbox, 2);
            this.gpx1Textbox.Enabled = false;
            this.gpx1Textbox.Location = new System.Drawing.Point(50, 7);
            this.gpx1Textbox.Name = "gpx1Textbox";
            this.gpx1Textbox.Size = new System.Drawing.Size(148, 20);
            this.gpx1Textbox.TabIndex = 1;
            // 
            // gpx2Label
            // 
            this.gpx2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpx2Label.AutoSize = true;
            this.gpx2Label.Location = new System.Drawing.Point(3, 46);
            this.gpx2Label.Name = "gpx2Label";
            this.gpx2Label.Size = new System.Drawing.Size(41, 13);
            this.gpx2Label.TabIndex = 3;
            this.gpx2Label.Text = "GPX 2:";
            // 
            // gpx2Textbox
            // 
            this.gpx2Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.concatTableLayout.SetColumnSpan(this.gpx2Textbox, 2);
            this.gpx2Textbox.Enabled = false;
            this.gpx2Textbox.Location = new System.Drawing.Point(50, 42);
            this.gpx2Textbox.Name = "gpx2Textbox";
            this.gpx2Textbox.Size = new System.Drawing.Size(148, 20);
            this.gpx2Textbox.TabIndex = 4;
            // 
            // selectGpx1Button
            // 
            this.selectGpx1Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectGpx1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectGpx1Button.BackgroundImage")));
            this.selectGpx1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectGpx1Button.Location = new System.Drawing.Point(204, 5);
            this.selectGpx1Button.Name = "selectGpx1Button";
            this.selectGpx1Button.Size = new System.Drawing.Size(25, 25);
            this.selectGpx1Button.TabIndex = 2;
            this.selectGpx1Button.UseVisualStyleBackColor = true;
            this.selectGpx1Button.Click += new System.EventHandler(this.OpenFileHandler);
            // 
            // selectGpx2Button
            // 
            this.selectGpx2Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectGpx2Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectGpx2Button.BackgroundImage")));
            this.selectGpx2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectGpx2Button.Location = new System.Drawing.Point(204, 40);
            this.selectGpx2Button.Name = "selectGpx2Button";
            this.selectGpx2Button.Size = new System.Drawing.Size(25, 25);
            this.selectGpx2Button.TabIndex = 5;
            this.selectGpx2Button.UseVisualStyleBackColor = true;
            this.selectGpx2Button.Click += new System.EventHandler(this.OpenFileHandler);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(3, 111);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveFileHandler);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(174, 111);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "GPX files (*.gpx)|*.gpx|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "GPX files (*.gpx)|*.gpx|All files (*.*)|*.*";
            // 
            // tabControl
            // 
            this.mainTable.SetColumnSpan(this.tabControl, 2);
            this.tabControl.Controls.Add(this.concatTab);
            this.tabControl.Controls.Add(this.tileGridTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(246, 102);
            this.tabControl.TabIndex = 1;
            this.tabControl.Tag = "";
            // 
            // concatTab
            // 
            this.concatTab.BackColor = System.Drawing.SystemColors.Control;
            this.concatTab.Controls.Add(this.concatTableLayout);
            this.concatTab.Location = new System.Drawing.Point(4, 22);
            this.concatTab.Name = "concatTab";
            this.concatTab.Padding = new System.Windows.Forms.Padding(3);
            this.concatTab.Size = new System.Drawing.Size(238, 76);
            this.concatTab.TabIndex = 0;
            this.concatTab.Tag = "concat";
            this.concatTab.Text = "Concatenate";
            // 
            // tileGridTab
            // 
            this.tileGridTab.BackColor = System.Drawing.SystemColors.Control;
            this.tileGridTab.Controls.Add(this.tileGridTableLayout);
            this.tileGridTab.Location = new System.Drawing.Point(4, 22);
            this.tileGridTab.Name = "tileGridTab";
            this.tileGridTab.Padding = new System.Windows.Forms.Padding(3);
            this.tileGridTab.Size = new System.Drawing.Size(238, 76);
            this.tileGridTab.TabIndex = 1;
            this.tileGridTab.Tag = "tiles";
            this.tileGridTab.Text = "Tile Grid";
            // 
            // tileGridTableLayout
            // 
            this.tileGridTableLayout.ColumnCount = 3;
            this.tileGridTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tileGridTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileGridTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileGridTableLayout.Controls.Add(this.latLonLabel, 0, 0);
            this.tileGridTableLayout.Controls.Add(this.latBox, 1, 0);
            this.tileGridTableLayout.Controls.Add(this.lonBox, 2, 0);
            this.tileGridTableLayout.Controls.Add(this.gridCountLabel, 0, 1);
            this.tileGridTableLayout.Controls.Add(this.gridRadiusEntry, 1, 1);
            this.tileGridTableLayout.Controls.Add(this.waypointCountResultLabel, 2, 1);
            this.tileGridTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileGridTableLayout.Location = new System.Drawing.Point(3, 3);
            this.tileGridTableLayout.Name = "tileGridTableLayout";
            this.tileGridTableLayout.RowCount = 2;
            this.tileGridTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileGridTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileGridTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tileGridTableLayout.Size = new System.Drawing.Size(232, 70);
            this.tileGridTableLayout.TabIndex = 0;
            // 
            // latLonLabel
            // 
            this.latLonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.latLonLabel.AutoSize = true;
            this.latLonLabel.Location = new System.Drawing.Point(3, 11);
            this.latLonLabel.Name = "latLonLabel";
            this.latLonLabel.Size = new System.Drawing.Size(72, 13);
            this.latLonLabel.TabIndex = 0;
            this.latLonLabel.Text = "Lat/Lon (deg)";
            this.latLonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // latBox
            // 
            this.latBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.latBox.Location = new System.Drawing.Point(81, 7);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(71, 20);
            this.latBox.TabIndex = 1;
            // 
            // lonBox
            // 
            this.lonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lonBox.Location = new System.Drawing.Point(158, 7);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(71, 20);
            this.lonBox.TabIndex = 3;
            // 
            // gridCountLabel
            // 
            this.gridCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCountLabel.AutoSize = true;
            this.gridCountLabel.Location = new System.Drawing.Point(3, 46);
            this.gridCountLabel.Name = "gridCountLabel";
            this.gridCountLabel.Size = new System.Drawing.Size(72, 13);
            this.gridCountLabel.TabIndex = 4;
            this.gridCountLabel.Text = "Grid Radius";
            this.gridCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridRadiusEntry
            // 
            this.gridRadiusEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridRadiusEntry.Location = new System.Drawing.Point(81, 42);
            this.gridRadiusEntry.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.gridRadiusEntry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gridRadiusEntry.Name = "gridRadiusEntry";
            this.gridRadiusEntry.Size = new System.Drawing.Size(71, 20);
            this.gridRadiusEntry.TabIndex = 8;
            this.gridRadiusEntry.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gridRadiusEntry.ValueChanged += new System.EventHandler(this.CalculatePointCount);
            // 
            // waypointCountResultLabel
            // 
            this.waypointCountResultLabel.AutoSize = true;
            this.waypointCountResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waypointCountResultLabel.Location = new System.Drawing.Point(158, 35);
            this.waypointCountResultLabel.Name = "waypointCountResultLabel";
            this.waypointCountResultLabel.Size = new System.Drawing.Size(71, 35);
            this.waypointCountResultLabel.TabIndex = 9;
            this.waypointCountResultLabel.Text = "36 points";
            this.waypointCountResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 2;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Controls.Add(this.tabControl, 0, 0);
            this.mainTable.Controls.Add(this.saveButton, 0, 1);
            this.mainTable.Controls.Add(this.exitButton, 1, 1);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 2;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTable.Size = new System.Drawing.Size(252, 146);
            this.mainTable.TabIndex = 2;
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(252, 146);
            this.Controls.Add(this.mainTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MergeForm";
            this.Text = "Merge GPX Tracks";
            this.concatTableLayout.ResumeLayout(false);
            this.concatTableLayout.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.concatTab.ResumeLayout(false);
            this.tileGridTab.ResumeLayout(false);
            this.tileGridTableLayout.ResumeLayout(false);
            this.tileGridTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRadiusEntry)).EndInit();
            this.mainTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel concatTableLayout;
        private System.Windows.Forms.Label gpx1Label;
        private System.Windows.Forms.TextBox gpx1Textbox;
        private System.Windows.Forms.Label gpx2Label;
        private System.Windows.Forms.TextBox gpx2Textbox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button selectGpx1Button;
        private System.Windows.Forms.Button selectGpx2Button;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TabPage concatTab;
        private System.Windows.Forms.TabPage tileGridTab;
        private System.Windows.Forms.TableLayoutPanel tileGridTableLayout;
        private System.Windows.Forms.Label latLonLabel;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.Label gridCountLabel;
        private System.Windows.Forms.NumericUpDown gridRadiusEntry;
        private System.Windows.Forms.Label waypointCountResultLabel;
    }
}

