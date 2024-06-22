namespace RegExFile
{
    partial class Form1
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
            this.textBoxRegEx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxFileWindow = new System.Windows.Forms.RichTextBox();
            this.buttonChoiceFile = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.buttonSelectPege = new System.Windows.Forms.Button();
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.hScrollBarFont = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // textBoxRegEx
            // 
            this.textBoxRegEx.Location = new System.Drawing.Point(178, 25);
            this.textBoxRegEx.Name = "textBoxRegEx";
            this.textBoxRegEx.Size = new System.Drawing.Size(642, 20);
            this.textBoxRegEx.TabIndex = 0;
            this.textBoxRegEx.TextChanged += new System.EventHandler(this.textBoxRegEx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regular Expression (Mark Unique Symbols)";
            // 
            // richTextBoxFileWindow
            // 
            this.richTextBoxFileWindow.Location = new System.Drawing.Point(45, 123);
            this.richTextBoxFileWindow.Name = "richTextBoxFileWindow";
            this.richTextBoxFileWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxFileWindow.Size = new System.Drawing.Size(775, 570);
            this.richTextBoxFileWindow.TabIndex = 2;
            this.richTextBoxFileWindow.Text = "";
            this.richTextBoxFileWindow.TextChanged += new System.EventHandler(this.richTextBoxFileWindow_TextChanged);
            // 
            // buttonChoiceFile
            // 
            this.buttonChoiceFile.Location = new System.Drawing.Point(45, 16);
            this.buttonChoiceFile.Name = "buttonChoiceFile";
            this.buttonChoiceFile.Size = new System.Drawing.Size(105, 36);
            this.buttonChoiceFile.TabIndex = 3;
            this.buttonChoiceFile.Text = "Choice File";
            this.buttonChoiceFile.UseVisualStyleBackColor = true;
            this.buttonChoiceFile.Click += new System.EventHandler(this.buttonChoiceFile_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(45, 94);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(745, 94);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(352, 104);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(24, 13);
            this.labelPages.TabIndex = 6;
            this.labelPages.Text = "0/0";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(858, 25);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 46);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(826, 159);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(93, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "S A V E";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(42, 706);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(63, 13);
            this.labelDestination.TabIndex = 9;
            this.labelDestination.Text = "Destination:";
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(346, 67);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(48, 20);
            this.textBoxPage.TabIndex = 10;
            // 
            // buttonSelectPege
            // 
            this.buttonSelectPege.Location = new System.Drawing.Point(400, 62);
            this.buttonSelectPege.Name = "buttonSelectPege";
            this.buttonSelectPege.Size = new System.Drawing.Size(75, 28);
            this.buttonSelectPege.TabIndex = 11;
            this.buttonSelectPege.Text = "Select Page";
            this.buttonSelectPege.UseVisualStyleBackColor = true;
            this.buttonSelectPege.Click += new System.EventHandler(this.buttonSelectPege_Click);
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            "TXT",
            "PDF",
            "DOCX"});
            this.comboBoxExtension.Location = new System.Drawing.Point(826, 123);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(93, 21);
            this.comboBoxExtension.TabIndex = 12;
            // 
            // hScrollBarFont
            // 
            this.hScrollBarFont.Location = new System.Drawing.Point(565, 73);
            this.hScrollBarFont.Name = "hScrollBarFont";
            this.hScrollBarFont.Size = new System.Drawing.Size(80, 17);
            this.hScrollBarFont.TabIndex = 13;
            this.hScrollBarFont.Value = 5;
            this.hScrollBarFont.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFont_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 755);
            this.Controls.Add(this.hScrollBarFont);
            this.Controls.Add(this.comboBoxExtension);
            this.Controls.Add(this.buttonSelectPege);
            this.Controls.Add(this.textBoxPage);
            this.Controls.Add(this.labelDestination);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonChoiceFile);
            this.Controls.Add(this.richTextBoxFileWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRegEx);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegExFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRegEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxFileWindow;
        private System.Windows.Forms.Button buttonChoiceFile;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxPage;
        private System.Windows.Forms.Button buttonSelectPege;
        private System.Windows.Forms.ComboBox comboBoxExtension;
        private System.Windows.Forms.HScrollBar hScrollBarFont;
    }
}

