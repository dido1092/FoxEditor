﻿namespace RegExFile
{
    partial class FrmPdfOcr
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
            this.buttonSelectOCR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPdfReader = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Language";
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Items.AddRange(new object[] {
            "Bul",
            "Eng",
            "Lat",
            "LatAlhaBet"});
            this.comboBoxLanguages.Location = new System.Drawing.Point(145, 102);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLanguages.TabIndex = 8;
            // 
            // buttonSelectOCR
            // 
            this.buttonSelectOCR.Location = new System.Drawing.Point(341, 22);
            this.buttonSelectOCR.Name = "buttonSelectOCR";
            this.buttonSelectOCR.Size = new System.Drawing.Size(98, 29);
            this.buttonSelectOCR.TabIndex = 7;
            this.buttonSelectOCR.Text = "Select";
            this.buttonSelectOCR.UseVisualStyleBackColor = true;
            this.buttonSelectOCR.Click += new System.EventHandler(this.buttonSelectOCR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Reader";
            // 
            // comboBoxPdfReader
            // 
            this.comboBoxPdfReader.FormattingEnabled = true;
            this.comboBoxPdfReader.Items.AddRange(new object[] {
            "Iron OCR",
            "IText Not OCR"});
            this.comboBoxPdfReader.Location = new System.Drawing.Point(145, 59);
            this.comboBoxPdfReader.Name = "comboBoxPdfReader";
            this.comboBoxPdfReader.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPdfReader.TabIndex = 5;
            this.comboBoxPdfReader.SelectedIndexChanged += new System.EventHandler(this.comboBoxPdfReader_SelectedIndexChanged);
            // 
            // FrmPdfOcr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLanguages);
            this.Controls.Add(this.buttonSelectOCR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPdfReader);
            this.Name = "FrmPdfOcr";
            this.Text = "FrmPdfOcr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.Button buttonSelectOCR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPdfReader;
    }
}