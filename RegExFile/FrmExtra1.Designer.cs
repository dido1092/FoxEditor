namespace RegExFile
{
    partial class FrmExtra1
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
            this.buttonToUpper = new System.Windows.Forms.Button();
            this.buttonToLower = new System.Windows.Forms.Button();
            this.buttonAbc = new System.Windows.Forms.Button();
            this.checkBoxForAllDocument = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonToUpper
            // 
            this.buttonToUpper.Location = new System.Drawing.Point(74, 76);
            this.buttonToUpper.Name = "buttonToUpper";
            this.buttonToUpper.Size = new System.Drawing.Size(106, 32);
            this.buttonToUpper.TabIndex = 0;
            this.buttonToUpper.Text = "ToUpper";
            this.buttonToUpper.UseVisualStyleBackColor = true;
            this.buttonToUpper.Click += new System.EventHandler(this.buttonToUpper_Click);
            // 
            // buttonToLower
            // 
            this.buttonToLower.Location = new System.Drawing.Point(74, 130);
            this.buttonToLower.Name = "buttonToLower";
            this.buttonToLower.Size = new System.Drawing.Size(106, 32);
            this.buttonToLower.TabIndex = 1;
            this.buttonToLower.Text = "ToLower";
            this.buttonToLower.UseVisualStyleBackColor = true;
            this.buttonToLower.Click += new System.EventHandler(this.buttonToLower_Click);
            // 
            // buttonAbc
            // 
            this.buttonAbc.Location = new System.Drawing.Point(74, 190);
            this.buttonAbc.Name = "buttonAbc";
            this.buttonAbc.Size = new System.Drawing.Size(106, 32);
            this.buttonAbc.TabIndex = 2;
            this.buttonAbc.Text = "Abc";
            this.buttonAbc.UseVisualStyleBackColor = true;
            this.buttonAbc.Click += new System.EventHandler(this.buttonAbc_Click);
            // 
            // checkBoxForAllDocument
            // 
            this.checkBoxForAllDocument.AutoSize = true;
            this.checkBoxForAllDocument.Location = new System.Drawing.Point(74, 22);
            this.checkBoxForAllDocument.Name = "checkBoxForAllDocument";
            this.checkBoxForAllDocument.Size = new System.Drawing.Size(107, 17);
            this.checkBoxForAllDocument.TabIndex = 3;
            this.checkBoxForAllDocument.Text = "For All Document";
            this.checkBoxForAllDocument.UseVisualStyleBackColor = true;
            this.checkBoxForAllDocument.CheckedChanged += new System.EventHandler(this.checkBoxForAllDocument_CheckedChanged);
            // 
            // FrmExtra1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 272);
            this.Controls.Add(this.checkBoxForAllDocument);
            this.Controls.Add(this.buttonAbc);
            this.Controls.Add(this.buttonToLower);
            this.Controls.Add(this.buttonToUpper);
            this.Name = "FrmExtra1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra1";
            this.Load += new System.EventHandler(this.FrmExtra1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToUpper;
        private System.Windows.Forms.Button buttonToLower;
        private System.Windows.Forms.Button buttonAbc;
        private System.Windows.Forms.CheckBox checkBoxForAllDocument;
    }
}