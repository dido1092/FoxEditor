namespace RegExFile
{
    partial class FrmExtractImagesFromPdf
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
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonOpenPdf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSameDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Location = new System.Drawing.Point(106, 122);
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.Size = new System.Drawing.Size(333, 20);
            this.textBoxDestination.TabIndex = 0;
            // 
            // buttonOpenPdf
            // 
            this.buttonOpenPdf.Location = new System.Drawing.Point(41, 30);
            this.buttonOpenPdf.Name = "buttonOpenPdf";
            this.buttonOpenPdf.Size = new System.Drawing.Size(103, 33);
            this.buttonOpenPdf.TabIndex = 1;
            this.buttonOpenPdf.Text = "Open PDF";
            this.buttonOpenPdf.UseVisualStyleBackColor = true;
            this.buttonOpenPdf.Click += new System.EventHandler(this.buttonOpenPdf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(445, 120);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(41, 214);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(479, 37);
            this.buttonExtract.TabIndex = 4;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(150, 40);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:";
            // 
            // buttonSameDir
            // 
            this.buttonSameDir.Location = new System.Drawing.Point(106, 93);
            this.buttonSameDir.Name = "buttonSameDir";
            this.buttonSameDir.Size = new System.Drawing.Size(75, 23);
            this.buttonSameDir.TabIndex = 6;
            this.buttonSameDir.Text = "Same Dir";
            this.buttonSameDir.UseVisualStyleBackColor = true;
            this.buttonSameDir.Click += new System.EventHandler(this.buttonSameDir_Click);
            // 
            // FrmExtractImagesFromPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 319);
            this.Controls.Add(this.buttonSameDir);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpenPdf);
            this.Controls.Add(this.textBoxDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmExtractImagesFromPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExtractImagesFromPdf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonOpenPdf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonSameDir;
    }
}