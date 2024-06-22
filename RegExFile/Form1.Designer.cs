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
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSaveAllPages = new System.Windows.Forms.CheckBox();
            this.progressBarSaveAllPages = new System.Windows.Forms.ProgressBar();
            this.buttonRemoveSpaces = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRememberText = new System.Windows.Forms.Button();
            this.checkBoxRememberText = new System.Windows.Forms.CheckBox();
            this.textBoxRememberText = new System.Windows.Forms.TextBox();
            this.buttonLoadRememberPage = new System.Windows.Forms.Button();
            this.buttonToUpper = new System.Windows.Forms.Button();
            this.buttonToLower = new System.Windows.Forms.Button();
            this.buttonAbv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRegEx
            // 
            this.textBoxRegEx.Location = new System.Drawing.Point(148, 25);
            this.textBoxRegEx.Name = "textBoxRegEx";
            this.textBoxRegEx.Size = new System.Drawing.Size(672, 20);
            this.textBoxRegEx.TabIndex = 0;
            this.textBoxRegEx.TextChanged += new System.EventHandler(this.textBoxRegEx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 9);
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
            this.richTextBoxFileWindow.Size = new System.Drawing.Size(775, 634);
            this.richTextBoxFileWindow.TabIndex = 2;
            this.richTextBoxFileWindow.Text = "";
            this.richTextBoxFileWindow.TextChanged += new System.EventHandler(this.richTextBoxFileWindow_TextChanged);
            // 
            // buttonChoiceFile
            // 
            this.buttonChoiceFile.Location = new System.Drawing.Point(45, 16);
            this.buttonChoiceFile.Name = "buttonChoiceFile";
            this.buttonChoiceFile.Size = new System.Drawing.Size(75, 36);
            this.buttonChoiceFile.TabIndex = 3;
            this.buttonChoiceFile.Text = "Open File";
            this.buttonChoiceFile.UseVisualStyleBackColor = true;
            this.buttonChoiceFile.Click += new System.EventHandler(this.buttonChoiceFile_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(210, 94);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(484, 94);
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
            this.buttonSave.Location = new System.Drawing.Point(826, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 29);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "S A V E  F I L E";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Location = new System.Drawing.Point(42, 772);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(63, 13);
            this.labelDestination.TabIndex = 9;
            this.labelDestination.Text = "Destination:";
            // 
            // textBoxPage
            // 
            this.textBoxPage.Location = new System.Drawing.Point(338, 67);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.Size = new System.Drawing.Size(56, 20);
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
            this.comboBoxExtension.Size = new System.Drawing.Size(96, 21);
            this.comboBoxExtension.TabIndex = 12;
            // 
            // hScrollBarFont
            // 
            this.hScrollBarFont.Location = new System.Drawing.Point(740, 67);
            this.hScrollBarFont.Name = "hScrollBarFont";
            this.hScrollBarFont.Size = new System.Drawing.Size(80, 17);
            this.hScrollBarFont.TabIndex = 13;
            this.hScrollBarFont.Value = 5;
            this.hScrollBarFont.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarFont_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Font Size";
            // 
            // checkBoxSaveAllPages
            // 
            this.checkBoxSaveAllPages.AutoSize = true;
            this.checkBoxSaveAllPages.Location = new System.Drawing.Point(826, 159);
            this.checkBoxSaveAllPages.Name = "checkBoxSaveAllPages";
            this.checkBoxSaveAllPages.Size = new System.Drawing.Size(96, 17);
            this.checkBoxSaveAllPages.TabIndex = 15;
            this.checkBoxSaveAllPages.Text = "Save all pages";
            this.checkBoxSaveAllPages.UseVisualStyleBackColor = true;
            this.checkBoxSaveAllPages.CheckedChanged += new System.EventHandler(this.checkBoxSaveAllPages_CheckedChanged);
            // 
            // progressBarSaveAllPages
            // 
            this.progressBarSaveAllPages.Location = new System.Drawing.Point(826, 261);
            this.progressBarSaveAllPages.Name = "progressBarSaveAllPages";
            this.progressBarSaveAllPages.Size = new System.Drawing.Size(96, 10);
            this.progressBarSaveAllPages.TabIndex = 16;
            // 
            // buttonRemoveSpaces
            // 
            this.buttonRemoveSpaces.Location = new System.Drawing.Point(1023, 226);
            this.buttonRemoveSpaces.Name = "buttonRemoveSpaces";
            this.buttonRemoveSpaces.Size = new System.Drawing.Size(96, 23);
            this.buttonRemoveSpaces.TabIndex = 17;
            this.buttonRemoveSpaces.Text = "Remove Spaces";
            this.buttonRemoveSpaces.UseVisualStyleBackColor = true;
            this.buttonRemoveSpaces.Click += new System.EventHandler(this.buttonRemoveSpaces_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Extensions";
            // 
            // buttonRememberText
            // 
            this.buttonRememberText.Location = new System.Drawing.Point(826, 325);
            this.buttonRememberText.Name = "buttonRememberText";
            this.buttonRememberText.Size = new System.Drawing.Size(152, 32);
            this.buttonRememberText.TabIndex = 20;
            this.buttonRememberText.Text = "Remember Page";
            this.buttonRememberText.UseVisualStyleBackColor = true;
            this.buttonRememberText.Click += new System.EventHandler(this.buttonRememberText_Click_1);
            // 
            // checkBoxRememberText
            // 
            this.checkBoxRememberText.AutoSize = true;
            this.checkBoxRememberText.Location = new System.Drawing.Point(826, 191);
            this.checkBoxRememberText.Name = "checkBoxRememberText";
            this.checkBoxRememberText.Size = new System.Drawing.Size(127, 17);
            this.checkBoxRememberText.TabIndex = 21;
            this.checkBoxRememberText.Text = "From Remember Text";
            this.checkBoxRememberText.UseVisualStyleBackColor = true;
            this.checkBoxRememberText.CheckedChanged += new System.EventHandler(this.checkBoxRememberText_CheckedChanged);
            // 
            // textBoxRememberText
            // 
            this.textBoxRememberText.Location = new System.Drawing.Point(826, 363);
            this.textBoxRememberText.Multiline = true;
            this.textBoxRememberText.Name = "textBoxRememberText";
            this.textBoxRememberText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRememberText.Size = new System.Drawing.Size(71, 127);
            this.textBoxRememberText.TabIndex = 22;
            // 
            // buttonLoadRememberPage
            // 
            this.buttonLoadRememberPage.Location = new System.Drawing.Point(903, 363);
            this.buttonLoadRememberPage.Name = "buttonLoadRememberPage";
            this.buttonLoadRememberPage.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadRememberPage.TabIndex = 23;
            this.buttonLoadRememberPage.Text = "Load Page";
            this.buttonLoadRememberPage.UseVisualStyleBackColor = true;
            this.buttonLoadRememberPage.Click += new System.EventHandler(this.buttonLoadRememberPage_Click);
            // 
            // buttonToUpper
            // 
            this.buttonToUpper.Location = new System.Drawing.Point(1023, 123);
            this.buttonToUpper.Name = "buttonToUpper";
            this.buttonToUpper.Size = new System.Drawing.Size(71, 23);
            this.buttonToUpper.TabIndex = 24;
            this.buttonToUpper.Text = "ToUpper";
            this.buttonToUpper.UseVisualStyleBackColor = true;
            this.buttonToUpper.Click += new System.EventHandler(this.buttonToUpper_Click);
            // 
            // buttonToLower
            // 
            this.buttonToLower.Location = new System.Drawing.Point(1114, 123);
            this.buttonToLower.Name = "buttonToLower";
            this.buttonToLower.Size = new System.Drawing.Size(67, 23);
            this.buttonToLower.TabIndex = 25;
            this.buttonToLower.Text = "ToLower";
            this.buttonToLower.UseVisualStyleBackColor = true;
            this.buttonToLower.Click += new System.EventHandler(this.buttonToLower_Click);
            // 
            // buttonAbv
            // 
            this.buttonAbv.Location = new System.Drawing.Point(1023, 171);
            this.buttonAbv.Name = "buttonAbv";
            this.buttonAbv.Size = new System.Drawing.Size(71, 23);
            this.buttonAbv.TabIndex = 26;
            this.buttonAbv.Text = "A b v";
            this.buttonAbv.UseVisualStyleBackColor = true;
            this.buttonAbv.Click += new System.EventHandler(this.buttonAbv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 803);
            this.Controls.Add(this.buttonAbv);
            this.Controls.Add(this.buttonToLower);
            this.Controls.Add(this.buttonToUpper);
            this.Controls.Add(this.buttonLoadRememberPage);
            this.Controls.Add(this.textBoxRememberText);
            this.Controls.Add(this.checkBoxRememberText);
            this.Controls.Add(this.buttonRememberText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemoveSpaces);
            this.Controls.Add(this.progressBarSaveAllPages);
            this.Controls.Add(this.checkBoxSaveAllPages);
            this.Controls.Add(this.label2);
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
            this.Text = "RegExTextEditor";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSaveAllPages;
        private System.Windows.Forms.ProgressBar progressBarSaveAllPages;
        private System.Windows.Forms.Button buttonRemoveSpaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRememberText;
        private System.Windows.Forms.CheckBox checkBoxRememberText;
        private System.Windows.Forms.TextBox textBoxRememberText;
        private System.Windows.Forms.Button buttonLoadRememberPage;
        private System.Windows.Forms.Button buttonToUpper;
        private System.Windows.Forms.Button buttonToLower;
        private System.Windows.Forms.Button buttonAbv;
    }
}

