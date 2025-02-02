namespace RegExFile
{
    partial class FrmMergeTxt
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.labelItems = new System.Windows.Forms.Label();
            this.labelSaveTo = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxFiles = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.checkBoxChange = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(37, 42);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(638, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(681, 38);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(82, 24);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(37, 210);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(726, 410);
            this.richTextBoxResult.TabIndex = 2;
            this.richTextBoxResult.Text = "";
            // 
            // labelItems
            // 
            this.labelItems.AutoSize = true;
            this.labelItems.Location = new System.Drawing.Point(34, 623);
            this.labelItems.Name = "labelItems";
            this.labelItems.Size = new System.Drawing.Size(35, 13);
            this.labelItems.TabIndex = 3;
            this.labelItems.Text = "Items:";
            // 
            // labelSaveTo
            // 
            this.labelSaveTo.AutoSize = true;
            this.labelSaveTo.Location = new System.Drawing.Point(34, 652);
            this.labelSaveTo.Name = "labelSaveTo";
            this.labelSaveTo.Size = new System.Drawing.Size(73, 13);
            this.labelSaveTo.TabIndex = 4;
            this.labelSaveTo.Text = "Path SaveTo:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(769, 210);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 34);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "S A V E";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBoxFiles
            // 
            this.richTextBoxFiles.Location = new System.Drawing.Point(37, 91);
            this.richTextBoxFiles.Name = "richTextBoxFiles";
            this.richTextBoxFiles.Size = new System.Drawing.Size(726, 86);
            this.richTextBoxFiles.TabIndex = 6;
            this.richTextBoxFiles.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "RESULT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FILES";
            // 
            // buttonMerge
            // 
            this.buttonMerge.Location = new System.Drawing.Point(888, 34);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(94, 34);
            this.buttonMerge.TabIndex = 9;
            this.buttonMerge.Text = "M E R G E";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "FROM";
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Items.AddRange(new object[] {
            "1=2",
            "1>2",
            "1<2"});
            this.comboBoxChoice.Location = new System.Drawing.Point(796, 38);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(67, 21);
            this.comboBoxChoice.TabIndex = 11;
            this.comboBoxChoice.SelectedIndexChanged += new System.EventHandler(this.comboBoxChoice_SelectedIndexChanged);
            // 
            // checkBoxChange
            // 
            this.checkBoxChange.AutoSize = true;
            this.checkBoxChange.Location = new System.Drawing.Point(796, 69);
            this.checkBoxChange.Name = "checkBoxChange";
            this.checkBoxChange.Size = new System.Drawing.Size(63, 17);
            this.checkBoxChange.TabIndex = 12;
            this.checkBoxChange.Text = "Change";
            this.checkBoxChange.UseVisualStyleBackColor = true;
            // 
            // FrmMergeTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 699);
            this.Controls.Add(this.checkBoxChange);
            this.Controls.Add(this.comboBoxChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxFiles);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelSaveTo);
            this.Controls.Add(this.labelItems);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMergeTxt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merge Txt Docs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label labelItems;
        private System.Windows.Forms.Label labelSaveTo;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBoxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.CheckBox checkBoxChange;
    }
}