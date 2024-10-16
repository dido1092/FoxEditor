namespace RegExFile
{
    partial class FrmFont
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBarFontSize = new System.Windows.Forms.HScrollBar();
            this.comboBoxFontNames = new System.Windows.Forms.ComboBox();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font Size";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Font Names:";
            // 
            // hScrollBarFontSize
            // 
            this.hScrollBarFontSize.Location = new System.Drawing.Point(89, 38);
            this.hScrollBarFontSize.Name = "hScrollBarFontSize";
            this.hScrollBarFontSize.Size = new System.Drawing.Size(112, 17);
            this.hScrollBarFontSize.TabIndex = 4;
            this.hScrollBarFontSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFontSize_Scroll);
            // 
            // comboBoxFontNames
            // 
            this.comboBoxFontNames.FormattingEnabled = true;
            this.comboBoxFontNames.Location = new System.Drawing.Point(334, 42);
            this.comboBoxFontNames.Name = "comboBoxFontNames";
            this.comboBoxFontNames.Size = new System.Drawing.Size(234, 21);
            this.comboBoxFontNames.TabIndex = 5;
            this.comboBoxFontNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontNames_SelectedIndexChanged);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(574, 40);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 6;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // FrmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 120);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.comboBoxFontNames);
            this.Controls.Add(this.hScrollBarFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFont";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font";
            this.Load += new System.EventHandler(this.FrmFont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBarFontSize;
        private System.Windows.Forms.ComboBox comboBoxFontNames;
        private System.Windows.Forms.Button buttonDefault;
    }
}