namespace RegExFile
{
    partial class FrmFind
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFind = new System.Windows.Forms.TabPage();
            this.buttonFindAllinCurrentDocument = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFind1 = new System.Windows.Forms.TextBox();
            this.buttonFindNext = new System.Windows.Forms.Button();
            this.tabPageReplace = new System.Windows.Forms.TabPage();
            this.buttonReplaceAllKindInCurrentPage = new System.Windows.Forms.Button();
            this.buttonRemoveSpace = new System.Windows.Forms.Button();
            this.buttonReplaceInCurrentPage = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFind2 = new System.Windows.Forms.TextBox();
            this.buttonFindNext2 = new System.Windows.Forms.Button();
            this.tabPageMark = new System.Windows.Forms.TabPage();
            this.buttonCopyMarketText = new System.Windows.Forms.Button();
            this.buttonClearAllMarks = new System.Windows.Forms.Button();
            this.buttonMarkInCurrentPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind3 = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.checkBoxRegularExpression = new System.Windows.Forms.CheckBox();
            this.checkBoxAnchor = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageFind.SuspendLayout();
            this.tabPageReplace.SuspendLayout();
            this.tabPageMark.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFind);
            this.tabControl1.Controls.Add(this.tabPageReplace);
            this.tabControl1.Controls.Add(this.tabPageMark);
            this.tabControl1.Location = new System.Drawing.Point(33, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 256);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFind
            // 
            this.tabPageFind.Controls.Add(this.buttonFindAllinCurrentDocument);
            this.tabPageFind.Controls.Add(this.buttonCount);
            this.tabPageFind.Controls.Add(this.label1);
            this.tabPageFind.Controls.Add(this.textBoxFind1);
            this.tabPageFind.Controls.Add(this.buttonFindNext);
            this.tabPageFind.Location = new System.Drawing.Point(4, 22);
            this.tabPageFind.Name = "tabPageFind";
            this.tabPageFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFind.Size = new System.Drawing.Size(470, 230);
            this.tabPageFind.TabIndex = 0;
            this.tabPageFind.Text = "Find";
            this.tabPageFind.UseVisualStyleBackColor = true;
            // 
            // buttonFindAllinCurrentDocument
            // 
            this.buttonFindAllinCurrentDocument.Location = new System.Drawing.Point(311, 113);
            this.buttonFindAllinCurrentDocument.Name = "buttonFindAllinCurrentDocument";
            this.buttonFindAllinCurrentDocument.Size = new System.Drawing.Size(124, 40);
            this.buttonFindAllinCurrentDocument.TabIndex = 7;
            this.buttonFindAllinCurrentDocument.Text = "Find All in Current Document";
            this.buttonFindAllinCurrentDocument.UseVisualStyleBackColor = true;
            this.buttonFindAllinCurrentDocument.Click += new System.EventHandler(this.buttonFindAllinCurrentDocument_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(312, 69);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(123, 25);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find:";
            // 
            // textBoxFind1
            // 
            this.textBoxFind1.Location = new System.Drawing.Point(61, 24);
            this.textBoxFind1.Name = "textBoxFind1";
            this.textBoxFind1.Size = new System.Drawing.Size(223, 20);
            this.textBoxFind1.TabIndex = 1;
            this.textBoxFind1.TextChanged += new System.EventHandler(this.textBoxFind1_TextChanged);
            // 
            // buttonFindNext
            // 
            this.buttonFindNext.Location = new System.Drawing.Point(312, 23);
            this.buttonFindNext.Name = "buttonFindNext";
            this.buttonFindNext.Size = new System.Drawing.Size(123, 25);
            this.buttonFindNext.TabIndex = 0;
            this.buttonFindNext.Text = "Find Next";
            this.buttonFindNext.UseVisualStyleBackColor = true;
            this.buttonFindNext.Click += new System.EventHandler(this.buttonFindNext_Click);
            // 
            // tabPageReplace
            // 
            this.tabPageReplace.Controls.Add(this.buttonReplaceAllKindInCurrentPage);
            this.tabPageReplace.Controls.Add(this.buttonRemoveSpace);
            this.tabPageReplace.Controls.Add(this.buttonReplaceInCurrentPage);
            this.tabPageReplace.Controls.Add(this.buttonReplace);
            this.tabPageReplace.Controls.Add(this.label3);
            this.tabPageReplace.Controls.Add(this.textBoxReplace);
            this.tabPageReplace.Controls.Add(this.label4);
            this.tabPageReplace.Controls.Add(this.textBoxFind2);
            this.tabPageReplace.Controls.Add(this.buttonFindNext2);
            this.tabPageReplace.Location = new System.Drawing.Point(4, 22);
            this.tabPageReplace.Name = "tabPageReplace";
            this.tabPageReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReplace.Size = new System.Drawing.Size(470, 230);
            this.tabPageReplace.TabIndex = 1;
            this.tabPageReplace.Text = "Replace";
            this.tabPageReplace.UseVisualStyleBackColor = true;
            // 
            // buttonReplaceAllKindInCurrentPage
            // 
            this.buttonReplaceAllKindInCurrentPage.Location = new System.Drawing.Point(314, 174);
            this.buttonReplaceAllKindInCurrentPage.Name = "buttonReplaceAllKindInCurrentPage";
            this.buttonReplaceAllKindInCurrentPage.Size = new System.Drawing.Size(123, 36);
            this.buttonReplaceAllKindInCurrentPage.TabIndex = 15;
            this.buttonReplaceAllKindInCurrentPage.Text = "Replace All Kind In Current Page";
            this.buttonReplaceAllKindInCurrentPage.UseVisualStyleBackColor = true;
            this.buttonReplaceAllKindInCurrentPage.Click += new System.EventHandler(this.buttonReplaceAllKindInCurrentPage_Click);
            // 
            // buttonRemoveSpace
            // 
            this.buttonRemoveSpace.Location = new System.Drawing.Point(91, 109);
            this.buttonRemoveSpace.Name = "buttonRemoveSpace";
            this.buttonRemoveSpace.Size = new System.Drawing.Size(91, 23);
            this.buttonRemoveSpace.TabIndex = 14;
            this.buttonRemoveSpace.Text = "Remove Space";
            this.buttonRemoveSpace.UseVisualStyleBackColor = true;
            this.buttonRemoveSpace.Click += new System.EventHandler(this.buttonRemoveSpace_Click);
            // 
            // buttonReplaceInCurrentPage
            // 
            this.buttonReplaceInCurrentPage.Location = new System.Drawing.Point(314, 118);
            this.buttonReplaceInCurrentPage.Name = "buttonReplaceInCurrentPage";
            this.buttonReplaceInCurrentPage.Size = new System.Drawing.Size(123, 38);
            this.buttonReplaceInCurrentPage.TabIndex = 13;
            this.buttonReplaceInCurrentPage.Text = "Replace In Current Page";
            this.buttonReplaceInCurrentPage.UseVisualStyleBackColor = true;
            this.buttonReplaceInCurrentPage.Click += new System.EventHandler(this.buttonReplaceInCurrentPage_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(314, 70);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(123, 25);
            this.buttonReplace.TabIndex = 12;
            this.buttonReplace.Text = "Replace Symbol";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Replace with:";
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(85, 70);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(199, 20);
            this.textBoxReplace.TabIndex = 10;
            this.textBoxReplace.TextChanged += new System.EventHandler(this.textBoxReplace_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Find:";
            // 
            // textBoxFind2
            // 
            this.textBoxFind2.Location = new System.Drawing.Point(61, 24);
            this.textBoxFind2.Name = "textBoxFind2";
            this.textBoxFind2.Size = new System.Drawing.Size(223, 20);
            this.textBoxFind2.TabIndex = 8;
            this.textBoxFind2.TextChanged += new System.EventHandler(this.textBoxFind2_TextChanged);
            // 
            // buttonFindNext2
            // 
            this.buttonFindNext2.Location = new System.Drawing.Point(314, 21);
            this.buttonFindNext2.Name = "buttonFindNext2";
            this.buttonFindNext2.Size = new System.Drawing.Size(123, 25);
            this.buttonFindNext2.TabIndex = 7;
            this.buttonFindNext2.Text = "Find Next";
            this.buttonFindNext2.UseVisualStyleBackColor = true;
            this.buttonFindNext2.Click += new System.EventHandler(this.buttonFindNext2_Click);
            // 
            // tabPageMark
            // 
            this.tabPageMark.Controls.Add(this.buttonCopyMarketText);
            this.tabPageMark.Controls.Add(this.buttonClearAllMarks);
            this.tabPageMark.Controls.Add(this.buttonMarkInCurrentPage);
            this.tabPageMark.Controls.Add(this.label2);
            this.tabPageMark.Controls.Add(this.textBoxFind3);
            this.tabPageMark.Location = new System.Drawing.Point(4, 22);
            this.tabPageMark.Name = "tabPageMark";
            this.tabPageMark.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMark.Size = new System.Drawing.Size(470, 230);
            this.tabPageMark.TabIndex = 2;
            this.tabPageMark.Text = "Mark";
            this.tabPageMark.UseVisualStyleBackColor = true;
            // 
            // buttonCopyMarketText
            // 
            this.buttonCopyMarketText.Location = new System.Drawing.Point(306, 124);
            this.buttonCopyMarketText.Name = "buttonCopyMarketText";
            this.buttonCopyMarketText.Size = new System.Drawing.Size(117, 28);
            this.buttonCopyMarketText.TabIndex = 7;
            this.buttonCopyMarketText.Text = "Copy Marked Text";
            this.buttonCopyMarketText.UseVisualStyleBackColor = true;
            this.buttonCopyMarketText.Click += new System.EventHandler(this.buttonCopyMarketText_Click);
            // 
            // buttonClearAllMarks
            // 
            this.buttonClearAllMarks.Location = new System.Drawing.Point(306, 73);
            this.buttonClearAllMarks.Name = "buttonClearAllMarks";
            this.buttonClearAllMarks.Size = new System.Drawing.Size(117, 28);
            this.buttonClearAllMarks.TabIndex = 6;
            this.buttonClearAllMarks.Text = "Clear all marks";
            this.buttonClearAllMarks.UseVisualStyleBackColor = true;
            this.buttonClearAllMarks.Click += new System.EventHandler(this.buttonClearAllMarks_Click);
            // 
            // buttonMarkInCurrentPage
            // 
            this.buttonMarkInCurrentPage.Location = new System.Drawing.Point(306, 23);
            this.buttonMarkInCurrentPage.Name = "buttonMarkInCurrentPage";
            this.buttonMarkInCurrentPage.Size = new System.Drawing.Size(117, 32);
            this.buttonMarkInCurrentPage.TabIndex = 5;
            this.buttonMarkInCurrentPage.Text = "Mark In Current Page";
            this.buttonMarkInCurrentPage.UseVisualStyleBackColor = true;
            this.buttonMarkInCurrentPage.Click += new System.EventHandler(this.buttonMarkInCurrentPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Find:";
            // 
            // textBoxFind3
            // 
            this.textBoxFind3.Location = new System.Drawing.Point(61, 24);
            this.textBoxFind3.Name = "textBoxFind3";
            this.textBoxFind3.Size = new System.Drawing.Size(223, 20);
            this.textBoxFind3.TabIndex = 3;
            this.textBoxFind3.TextChanged += new System.EventHandler(this.textBoxFind3_TextChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(30, 303);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(31, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Info: ";
            // 
            // checkBoxRegularExpression
            // 
            this.checkBoxRegularExpression.AutoSize = true;
            this.checkBoxRegularExpression.Location = new System.Drawing.Point(33, 274);
            this.checkBoxRegularExpression.Name = "checkBoxRegularExpression";
            this.checkBoxRegularExpression.Size = new System.Drawing.Size(117, 17);
            this.checkBoxRegularExpression.TabIndex = 2;
            this.checkBoxRegularExpression.Text = "Regular Expression";
            this.checkBoxRegularExpression.UseVisualStyleBackColor = true;
            this.checkBoxRegularExpression.CheckedChanged += new System.EventHandler(this.checkBoxRegularExpression_CheckedChanged);
            // 
            // checkBoxAnchor
            // 
            this.checkBoxAnchor.AutoSize = true;
            this.checkBoxAnchor.Location = new System.Drawing.Point(443, 274);
            this.checkBoxAnchor.Name = "checkBoxAnchor";
            this.checkBoxAnchor.Size = new System.Drawing.Size(60, 17);
            this.checkBoxAnchor.TabIndex = 3;
            this.checkBoxAnchor.Text = "Anchor";
            this.checkBoxAnchor.UseVisualStyleBackColor = true;
            // 
            // FrmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 334);
            this.Controls.Add(this.checkBoxAnchor);
            this.Controls.Add(this.checkBoxRegularExpression);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.Load += new System.EventHandler(this.Find_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFind.ResumeLayout(false);
            this.tabPageFind.PerformLayout();
            this.tabPageReplace.ResumeLayout(false);
            this.tabPageReplace.PerformLayout();
            this.tabPageMark.ResumeLayout(false);
            this.tabPageMark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFind;
        private System.Windows.Forms.Button buttonFindNext;
        private System.Windows.Forms.TabPage tabPageReplace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonReplaceInCurrentPage;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFindNext2;
        private System.Windows.Forms.Button buttonFindAllinCurrentDocument;
        private System.Windows.Forms.TabPage tabPageMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClearAllMarks;
        private System.Windows.Forms.Button buttonMarkInCurrentPage;
        private System.Windows.Forms.Button buttonCopyMarketText;
        public System.Windows.Forms.TextBox textBoxReplace;
        public System.Windows.Forms.TextBox textBoxFind2;
        public System.Windows.Forms.TextBox textBoxFind1;
        public System.Windows.Forms.TextBox textBoxFind3;
        private System.Windows.Forms.CheckBox checkBoxRegularExpression;
        private System.Windows.Forms.Button buttonRemoveSpace;
        private System.Windows.Forms.Button buttonReplaceAllKindInCurrentPage;
        private System.Windows.Forms.CheckBox checkBoxAnchor;
    }
}