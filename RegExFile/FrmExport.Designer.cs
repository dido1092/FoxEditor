namespace RegExFile
{
    partial class FrmExport
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
            this.comboBoxExtenssions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSaveAllPages = new System.Windows.Forms.CheckBox();
            this.checkBoxFromRememberPages = new System.Windows.Forms.CheckBox();
            this.buttonExportTo = new System.Windows.Forms.Button();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // comboBoxExtenssions
            // 
            this.comboBoxExtenssions.FormattingEnabled = true;
            this.comboBoxExtenssions.Items.AddRange(new object[] {
            "TXT",
            "DOCX",
            "PDF"});
            this.comboBoxExtenssions.Location = new System.Drawing.Point(53, 127);
            this.comboBoxExtenssions.Name = "comboBoxExtenssions";
            this.comboBoxExtenssions.Size = new System.Drawing.Size(60, 21);
            this.comboBoxExtenssions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Extenssions";
            // 
            // checkBoxSaveAllPages
            // 
            this.checkBoxSaveAllPages.AutoSize = true;
            this.checkBoxSaveAllPages.Location = new System.Drawing.Point(53, 25);
            this.checkBoxSaveAllPages.Name = "checkBoxSaveAllPages";
            this.checkBoxSaveAllPages.Size = new System.Drawing.Size(98, 17);
            this.checkBoxSaveAllPages.TabIndex = 2;
            this.checkBoxSaveAllPages.Text = "Save All Pages";
            this.checkBoxSaveAllPages.UseVisualStyleBackColor = true;
            this.checkBoxSaveAllPages.CheckedChanged += new System.EventHandler(this.checkBoxSaveAllPages_CheckedChanged);
            // 
            // checkBoxFromRememberPages
            // 
            this.checkBoxFromRememberPages.AutoSize = true;
            this.checkBoxFromRememberPages.Location = new System.Drawing.Point(53, 57);
            this.checkBoxFromRememberPages.Name = "checkBoxFromRememberPages";
            this.checkBoxFromRememberPages.Size = new System.Drawing.Size(136, 17);
            this.checkBoxFromRememberPages.TabIndex = 3;
            this.checkBoxFromRememberPages.Text = "From Remember Pages";
            this.checkBoxFromRememberPages.UseVisualStyleBackColor = true;
            this.checkBoxFromRememberPages.CheckedChanged += new System.EventHandler(this.checkBoxFromRememberPages_CheckedChanged);
            // 
            // buttonExportTo
            // 
            this.buttonExportTo.Location = new System.Drawing.Point(53, 169);
            this.buttonExportTo.Name = "buttonExportTo";
            this.buttonExportTo.Size = new System.Drawing.Size(118, 34);
            this.buttonExportTo.TabIndex = 4;
            this.buttonExportTo.Text = "EXPORT TO";
            this.buttonExportTo.UseVisualStyleBackColor = true;
            this.buttonExportTo.Click += new System.EventHandler(this.buttonExportTo_Click);
            // 
            // progressBarExport
            // 
            this.progressBarExport.Location = new System.Drawing.Point(53, 209);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(118, 11);
            this.progressBarExport.TabIndex = 5;
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 292);
            this.Controls.Add(this.progressBarExport);
            this.Controls.Add(this.buttonExportTo);
            this.Controls.Add(this.checkBoxFromRememberPages);
            this.Controls.Add(this.checkBoxSaveAllPages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExtenssions);
            this.Name = "FrmExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExtenssions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSaveAllPages;
        private System.Windows.Forms.CheckBox checkBoxFromRememberPages;
        private System.Windows.Forms.Button buttonExportTo;
        private System.Windows.Forms.ProgressBar progressBarExport;
    }
}