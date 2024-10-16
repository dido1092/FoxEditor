namespace RegExFile
{
    partial class FrmImagesWindow
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
            this.comboBoxImageReader = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectOCR = new System.Windows.Forms.Button();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxImageReader
            // 
            this.comboBoxImageReader.FormattingEnabled = true;
            this.comboBoxImageReader.Items.AddRange(new object[] {
            "Iron OCR",
            "Tesseract OCR"});
            this.comboBoxImageReader.Location = new System.Drawing.Point(114, 55);
            this.comboBoxImageReader.Name = "comboBoxImageReader";
            this.comboBoxImageReader.Size = new System.Drawing.Size(100, 21);
            this.comboBoxImageReader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select OCR";
            // 
            // buttonSelectOCR
            // 
            this.buttonSelectOCR.Location = new System.Drawing.Point(291, 24);
            this.buttonSelectOCR.Name = "buttonSelectOCR";
            this.buttonSelectOCR.Size = new System.Drawing.Size(98, 29);
            this.buttonSelectOCR.TabIndex = 2;
            this.buttonSelectOCR.Text = "Select";
            this.buttonSelectOCR.UseVisualStyleBackColor = true;
            this.buttonSelectOCR.Click += new System.EventHandler(this.buttonSelectOCR_Click);
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Items.AddRange(new object[] {
            "Bul",
            "Eng"});
            this.comboBoxLanguages.Location = new System.Drawing.Point(114, 98);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLanguages.TabIndex = 3;
            this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Language";
            // 
            // FrmImagesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 190);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.buttonSelectOCR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxImageReader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmImagesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxImageReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectOCR;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.Label label2;
    }
}