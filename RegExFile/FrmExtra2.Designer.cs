namespace RegExFile
{
    partial class FrmExtra2
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.checkBoxInRow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(117, 34);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(131, 46);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "CHANGE POSITIONS";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // checkBoxInRow
            // 
            this.checkBoxInRow.AutoSize = true;
            this.checkBoxInRow.Location = new System.Drawing.Point(39, 34);
            this.checkBoxInRow.Name = "checkBoxInRow";
            this.checkBoxInRow.Size = new System.Drawing.Size(60, 17);
            this.checkBoxInRow.TabIndex = 2;
            this.checkBoxInRow.Text = "In Row";
            this.checkBoxInRow.UseVisualStyleBackColor = true;
            // 
            // FrmExtra2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 498);
            this.Controls.Add(this.checkBoxInRow);
            this.Controls.Add(this.buttonChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmExtra2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExtra2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.CheckBox checkBoxInRow;
    }
}