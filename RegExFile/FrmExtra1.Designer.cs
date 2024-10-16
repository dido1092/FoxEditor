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
            this.checkBoxSelectAllInPage = new System.Windows.Forms.CheckBox();
            this.buttonRemoveSpaces = new System.Windows.Forms.Button();
            this.buttonRemoveEquals = new System.Windows.Forms.Button();
            this.buttonIsCyrillic = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxForAllDocument = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonToUpper
            // 
            this.buttonToUpper.Location = new System.Drawing.Point(74, 93);
            this.buttonToUpper.Name = "buttonToUpper";
            this.buttonToUpper.Size = new System.Drawing.Size(106, 32);
            this.buttonToUpper.TabIndex = 0;
            this.buttonToUpper.Text = "ToUpper";
            this.buttonToUpper.UseVisualStyleBackColor = true;
            this.buttonToUpper.Click += new System.EventHandler(this.buttonToUpper_Click);
            // 
            // buttonToLower
            // 
            this.buttonToLower.Location = new System.Drawing.Point(74, 147);
            this.buttonToLower.Name = "buttonToLower";
            this.buttonToLower.Size = new System.Drawing.Size(106, 32);
            this.buttonToLower.TabIndex = 1;
            this.buttonToLower.Text = "ToLower";
            this.buttonToLower.UseVisualStyleBackColor = true;
            this.buttonToLower.Click += new System.EventHandler(this.buttonToLower_Click);
            // 
            // buttonAbc
            // 
            this.buttonAbc.Location = new System.Drawing.Point(74, 203);
            this.buttonAbc.Name = "buttonAbc";
            this.buttonAbc.Size = new System.Drawing.Size(106, 32);
            this.buttonAbc.TabIndex = 2;
            this.buttonAbc.Text = "Abc";
            this.buttonAbc.UseVisualStyleBackColor = true;
            this.buttonAbc.Click += new System.EventHandler(this.buttonAbc_Click);
            // 
            // checkBoxSelectAllInPage
            // 
            this.checkBoxSelectAllInPage.AutoSize = true;
            this.checkBoxSelectAllInPage.Location = new System.Drawing.Point(74, 61);
            this.checkBoxSelectAllInPage.Name = "checkBoxSelectAllInPage";
            this.checkBoxSelectAllInPage.Size = new System.Drawing.Size(109, 17);
            this.checkBoxSelectAllInPage.TabIndex = 4;
            this.checkBoxSelectAllInPage.Text = "Select All in Page";
            this.checkBoxSelectAllInPage.UseVisualStyleBackColor = true;
            this.checkBoxSelectAllInPage.CheckedChanged += new System.EventHandler(this.checkBoxSelectAllInPage_CheckedChanged);
            // 
            // buttonRemoveSpaces
            // 
            this.buttonRemoveSpaces.Location = new System.Drawing.Point(74, 273);
            this.buttonRemoveSpaces.Name = "buttonRemoveSpaces";
            this.buttonRemoveSpaces.Size = new System.Drawing.Size(106, 30);
            this.buttonRemoveSpaces.TabIndex = 5;
            this.buttonRemoveSpaces.Text = "Spaces Remove";
            this.buttonRemoveSpaces.UseVisualStyleBackColor = true;
            this.buttonRemoveSpaces.Click += new System.EventHandler(this.buttonRemoveSpaces_Click);
            // 
            // buttonRemoveEquals
            // 
            this.buttonRemoveEquals.Location = new System.Drawing.Point(74, 328);
            this.buttonRemoveEquals.Name = "buttonRemoveEquals";
            this.buttonRemoveEquals.Size = new System.Drawing.Size(106, 30);
            this.buttonRemoveEquals.TabIndex = 6;
            this.buttonRemoveEquals.Text = "Equals Remove";
            this.buttonRemoveEquals.UseVisualStyleBackColor = true;
            this.buttonRemoveEquals.Click += new System.EventHandler(this.buttonRemoveEquals_Click);
            // 
            // buttonIsCyrillic
            // 
            this.buttonIsCyrillic.Location = new System.Drawing.Point(74, 382);
            this.buttonIsCyrillic.Name = "buttonIsCyrillic";
            this.buttonIsCyrillic.Size = new System.Drawing.Size(106, 28);
            this.buttonIsCyrillic.TabIndex = 7;
            this.buttonIsCyrillic.Text = "Is Cyrillic Letter";
            this.buttonIsCyrillic.UseVisualStyleBackColor = true;
            this.buttonIsCyrillic.Click += new System.EventHandler(this.buttonIsCyrillic_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(13, 441);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(28, 13);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = "Info:";
            // 
            // checkBoxForAllDocument
            // 
            this.checkBoxForAllDocument.AutoSize = true;
            this.checkBoxForAllDocument.Location = new System.Drawing.Point(74, 27);
            this.checkBoxForAllDocument.Name = "checkBoxForAllDocument";
            this.checkBoxForAllDocument.Size = new System.Drawing.Size(107, 17);
            this.checkBoxForAllDocument.TabIndex = 9;
            this.checkBoxForAllDocument.Text = "For All Document";
            this.checkBoxForAllDocument.UseVisualStyleBackColor = true;
            this.checkBoxForAllDocument.CheckedChanged += new System.EventHandler(this.checkBoxForAllDocument_CheckedChanged_1);
            // 
            // FrmExtra1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 466);
            this.Controls.Add(this.checkBoxForAllDocument);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonIsCyrillic);
            this.Controls.Add(this.buttonRemoveEquals);
            this.Controls.Add(this.buttonRemoveSpaces);
            this.Controls.Add(this.checkBoxSelectAllInPage);
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
        private System.Windows.Forms.CheckBox checkBoxSelectAllInPage;
        private System.Windows.Forms.Button buttonRemoveSpaces;
        private System.Windows.Forms.Button buttonRemoveEquals;
        private System.Windows.Forms.Button buttonIsCyrillic;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckBox checkBoxForAllDocument;
    }
}