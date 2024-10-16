namespace RegExFile
{
    partial class FrmConvertLetters
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
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxConvertFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxConvertTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxLetters = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(266, 34);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(107, 42);
            this.buttonConvert.TabIndex = 0;
            this.buttonConvert.Text = "Convert In Page";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxConvertFrom
            // 
            this.comboBoxConvertFrom.FormattingEnabled = true;
            this.comboBoxConvertFrom.Items.AddRange(new object[] {
            "Bg",
            "En"});
            this.comboBoxConvertFrom.Location = new System.Drawing.Point(48, 46);
            this.comboBoxConvertFrom.Name = "comboBoxConvertFrom";
            this.comboBoxConvertFrom.Size = new System.Drawing.Size(72, 21);
            this.comboBoxConvertFrom.TabIndex = 1;
            this.comboBoxConvertFrom.SelectedIndexChanged += new System.EventHandler(this.comboBoxConvertFrom_SelectedIndexChanged);
            // 
            // comboBoxConvertTo
            // 
            this.comboBoxConvertTo.FormattingEnabled = true;
            this.comboBoxConvertTo.Items.AddRange(new object[] {
            "En",
            "Bg"});
            this.comboBoxConvertTo.Location = new System.Drawing.Point(153, 46);
            this.comboBoxConvertTo.Name = "comboBoxConvertTo";
            this.comboBoxConvertTo.Size = new System.Drawing.Size(72, 21);
            this.comboBoxConvertTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // checkedListBoxLetters
            // 
            this.checkedListBoxLetters.FormattingEnabled = true;
            this.checkedListBoxLetters.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "E",
            "H",
            "K",
            "M",
            "O",
            "P",
            "T",
            "X",
            "Y",
            "a",
            "c",
            "e",
            "k",
            "m",
            "n",
            "o",
            "p",
            "x",
            "y"});
            this.checkedListBoxLetters.Location = new System.Drawing.Point(48, 160);
            this.checkedListBoxLetters.Name = "checkedListBoxLetters";
            this.checkedListBoxLetters.Size = new System.Drawing.Size(99, 94);
            this.checkedListBoxLetters.TabIndex = 6;
            this.checkedListBoxLetters.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxLetters_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Included letters";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(153, 160);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAll.TabIndex = 8;
            this.checkBoxAll.Text = "CheckAll";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // FrmConvertLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 288);
            this.Controls.Add(this.checkBoxAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBoxLetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxConvertTo);
            this.Controls.Add(this.comboBoxConvertFrom);
            this.Controls.Add(this.buttonConvert);
            this.Name = "FrmConvertLetters";
            this.Text = "ConvertLetters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxConvertFrom;
        private System.Windows.Forms.ComboBox comboBoxConvertTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxLetters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAll;
    }
}