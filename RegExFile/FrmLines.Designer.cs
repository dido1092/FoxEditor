namespace RegExFile
{
    partial class FrmLines
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
            this.comboBoxLines = new System.Windows.Forms.ComboBox();
            this.buttonChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLines
            // 
            this.comboBoxLines.FormattingEnabled = true;
            this.comboBoxLines.Items.AddRange(new object[] {
            "20",
            "40",
            "60",
            "80",
            "100"});
            this.comboBoxLines.Location = new System.Drawing.Point(146, 41);
            this.comboBoxLines.Name = "comboBoxLines";
            this.comboBoxLines.Size = new System.Drawing.Size(74, 21);
            this.comboBoxLines.TabIndex = 0;
            // 
            // buttonChoice
            // 
            this.buttonChoice.Location = new System.Drawing.Point(240, 39);
            this.buttonChoice.Name = "buttonChoice";
            this.buttonChoice.Size = new System.Drawing.Size(75, 23);
            this.buttonChoice.TabIndex = 1;
            this.buttonChoice.Text = "Choice";
            this.buttonChoice.UseVisualStyleBackColor = true;
            this.buttonChoice.Click += new System.EventHandler(this.buttonChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choice Lines Per Page";
            // 
            // FrmLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoice);
            this.Controls.Add(this.comboBoxLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmLines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLines";
            this.Load += new System.EventHandler(this.FrmLines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChoice;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxLines;
    }
}