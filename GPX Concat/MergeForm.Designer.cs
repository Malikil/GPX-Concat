
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpx1Label = new System.Windows.Forms.Label();
            this.gpx1Textbox = new System.Windows.Forms.TextBox();
            this.gpx2Label = new System.Windows.Forms.Label();
            this.gpx2Textbox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.selectGpx1Button = new System.Windows.Forms.Button();
            this.selectGpx2Button = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gpx1Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpx1Textbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpx2Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gpx2Textbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.saveButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.selectGpx1Button, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectGpx2Button, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gpx1Label
            // 
            this.gpx1Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpx1Label.AutoSize = true;
            this.gpx1Label.Location = new System.Drawing.Point(3, 9);
            this.gpx1Label.Name = "gpx1Label";
            this.gpx1Label.Size = new System.Drawing.Size(41, 13);
            this.gpx1Label.TabIndex = 0;
            this.gpx1Label.Text = "GPX 1:";
            // 
            // gpx1Textbox
            // 
            this.gpx1Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gpx1Textbox, 2);
            this.gpx1Textbox.Enabled = false;
            this.gpx1Textbox.Location = new System.Drawing.Point(50, 5);
            this.gpx1Textbox.Name = "gpx1Textbox";
            this.gpx1Textbox.Size = new System.Drawing.Size(168, 20);
            this.gpx1Textbox.TabIndex = 1;
            // 
            // gpx2Label
            // 
            this.gpx2Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gpx2Label.AutoSize = true;
            this.gpx2Label.Location = new System.Drawing.Point(3, 40);
            this.gpx2Label.Name = "gpx2Label";
            this.gpx2Label.Size = new System.Drawing.Size(41, 13);
            this.gpx2Label.TabIndex = 3;
            this.gpx2Label.Text = "GPX 2:";
            // 
            // gpx2Textbox
            // 
            this.gpx2Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gpx2Textbox, 2);
            this.gpx2Textbox.Enabled = false;
            this.gpx2Textbox.Location = new System.Drawing.Point(50, 36);
            this.gpx2Textbox.Name = "gpx2Textbox";
            this.gpx2Textbox.Size = new System.Drawing.Size(168, 20);
            this.gpx2Textbox.TabIndex = 4;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.saveButton, 2);
            this.saveButton.Location = new System.Drawing.Point(3, 65);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 32);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveFileHandler);
            // 
            // selectGpx1Button
            // 
            this.selectGpx1Button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.selectGpx1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selectGpx1Button.BackgroundImage")));
            this.selectGpx1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectGpx1Button.Location = new System.Drawing.Point(224, 3);
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
            this.selectGpx2Button.Location = new System.Drawing.Point(224, 34);
            this.selectGpx2Button.Name = "selectGpx2Button";
            this.selectGpx2Button.Size = new System.Drawing.Size(25, 25);
            this.selectGpx2Button.TabIndex = 5;
            this.selectGpx2Button.UseVisualStyleBackColor = true;
            this.selectGpx2Button.Click += new System.EventHandler(this.OpenFileHandler);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.exitButton, 2);
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(174, 65);
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
            this.saveFileDialog.FileName = "Merged_GPX.gpx";
            this.saveFileDialog.Filter = "GPX files (*.gpx)|*.gpx|All files (*.*)|*.*";
            // 
            // MergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(252, 100);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MergeForm";
            this.Text = "Merge GPX Tracks";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}

