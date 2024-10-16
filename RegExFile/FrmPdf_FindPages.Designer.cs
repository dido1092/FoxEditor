namespace RegExFile
{
    partial class FrmPdf_FindPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPdf_FindPages));
            this.textBoxPages = new System.Windows.Forms.TextBox();
            this.textBoxFindWord = new System.Windows.Forms.TextBox();
            this.buttonFindWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.labelSelectedPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPages
            // 
            this.textBoxPages.Location = new System.Drawing.Point(32, 116);
            this.textBoxPages.Multiline = true;
            this.textBoxPages.Name = "textBoxPages";
            this.textBoxPages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPages.Size = new System.Drawing.Size(70, 201);
            this.textBoxPages.TabIndex = 3;
            // 
            // textBoxFindWord
            // 
            this.textBoxFindWord.Location = new System.Drawing.Point(29, 53);
            this.textBoxFindWord.Name = "textBoxFindWord";
            this.textBoxFindWord.Size = new System.Drawing.Size(154, 20);
            this.textBoxFindWord.TabIndex = 1;
            // 
            // buttonFindWord
            // 
            this.buttonFindWord.Location = new System.Drawing.Point(200, 48);
            this.buttonFindWord.Name = "buttonFindWord";
            this.buttonFindWord.Size = new System.Drawing.Size(87, 29);
            this.buttonFindWord.TabIndex = 2;
            this.buttonFindWord.Text = "Find Pages";
            this.buttonFindWord.UseVisualStyleBackColor = true;
            this.buttonFindWord.Click += new System.EventHandler(this.buttonFindWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pages";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(108, 116);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 29);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // labelSelectedPage
            // 
            this.labelSelectedPage.AutoSize = true;
            this.labelSelectedPage.Location = new System.Drawing.Point(29, 320);
            this.labelSelectedPage.Name = "labelSelectedPage";
            this.labelSelectedPage.Size = new System.Drawing.Size(35, 13);
            this.labelSelectedPage.TabIndex = 11;
            this.labelSelectedPage.Text = "Pege:";
            // 
            // FrmPdf_FindPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 365);
            this.Controls.Add(this.labelSelectedPage);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFindWord);
            this.Controls.Add(this.textBoxFindWord);
            this.Controls.Add(this.textBoxPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPdf_FindPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pdf Find Pages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPages;
        private System.Windows.Forms.TextBox textBoxFindWord;
        private System.Windows.Forms.Button buttonFindWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label labelSelectedPage;
    }
}