namespace RegExFile
{
    partial class FrmDatabase
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
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.progressBarImport = new System.Windows.Forms.ProgressBar();
            this.comboBoxDBLanguage = new System.Windows.Forms.ComboBox();
            this.buttonShowDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(511, 46);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(110, 27);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(29, 46);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(376, 20);
            this.textBoxInsert.TabIndex = 1;
            // 
            // progressBarImport
            // 
            this.progressBarImport.Location = new System.Drawing.Point(511, 79);
            this.progressBarImport.Name = "progressBarImport";
            this.progressBarImport.Size = new System.Drawing.Size(110, 10);
            this.progressBarImport.TabIndex = 2;
            // 
            // comboBoxDBLanguage
            // 
            this.comboBoxDBLanguage.FormattingEnabled = true;
            this.comboBoxDBLanguage.Items.AddRange(new object[] {
            "BG",
            "EN",
            "EN_Transcript"});
            this.comboBoxDBLanguage.Location = new System.Drawing.Point(411, 46);
            this.comboBoxDBLanguage.Name = "comboBoxDBLanguage";
            this.comboBoxDBLanguage.Size = new System.Drawing.Size(75, 21);
            this.comboBoxDBLanguage.TabIndex = 3;
            // 
            // buttonShowDB
            // 
            this.buttonShowDB.Location = new System.Drawing.Point(411, 79);
            this.buttonShowDB.Name = "buttonShowDB";
            this.buttonShowDB.Size = new System.Drawing.Size(75, 23);
            this.buttonShowDB.TabIndex = 4;
            this.buttonShowDB.Text = "Show DB";
            this.buttonShowDB.UseVisualStyleBackColor = true;
            this.buttonShowDB.Click += new System.EventHandler(this.buttonShowDB_Click);
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 184);
            this.Controls.Add(this.buttonShowDB);
            this.Controls.Add(this.comboBoxDBLanguage);
            this.Controls.Add(this.progressBarImport);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.buttonInsert);
            this.Name = "FrmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.ProgressBar progressBarImport;
        private System.Windows.Forms.ComboBox comboBoxDBLanguage;
        private System.Windows.Forms.Button buttonShowDB;
    }
}