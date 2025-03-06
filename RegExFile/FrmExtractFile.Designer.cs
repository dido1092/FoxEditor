namespace RegExFile
{
    partial class FrmExtractFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExtractFile));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.textBoxSymbols = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddSymbols = new System.Windows.Forms.Button();
            this.buttonConvertAndExport = new System.Windows.Forms.Button();
            this.buttonSuggestSymbols = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // textBoxSymbols
            // 
            this.textBoxSymbols.Location = new System.Drawing.Point(29, 74);
            this.textBoxSymbols.Name = "textBoxSymbols";
            this.textBoxSymbols.Size = new System.Drawing.Size(450, 20);
            this.textBoxSymbols.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter symbols for spliting";
            // 
            // buttonAddSymbols
            // 
            this.buttonAddSymbols.Location = new System.Drawing.Point(485, 71);
            this.buttonAddSymbols.Name = "buttonAddSymbols";
            this.buttonAddSymbols.Size = new System.Drawing.Size(101, 24);
            this.buttonAddSymbols.TabIndex = 4;
            this.buttonAddSymbols.Text = "Add Symbols";
            this.buttonAddSymbols.UseVisualStyleBackColor = true;
            this.buttonAddSymbols.Click += new System.EventHandler(this.buttonAddSymbols_Click);
            // 
            // buttonConvertAndExport
            // 
            this.buttonConvertAndExport.Location = new System.Drawing.Point(679, 57);
            this.buttonConvertAndExport.Name = "buttonConvertAndExport";
            this.buttonConvertAndExport.Size = new System.Drawing.Size(114, 38);
            this.buttonConvertAndExport.TabIndex = 5;
            this.buttonConvertAndExport.Text = "Convert And Export";
            this.buttonConvertAndExport.UseVisualStyleBackColor = true;
            this.buttonConvertAndExport.Click += new System.EventHandler(this.buttonConvertAndExport_Click);
            // 
            // buttonSuggestSymbols
            // 
            this.buttonSuggestSymbols.Location = new System.Drawing.Point(29, 100);
            this.buttonSuggestSymbols.Name = "buttonSuggestSymbols";
            this.buttonSuggestSymbols.Size = new System.Drawing.Size(107, 24);
            this.buttonSuggestSymbols.TabIndex = 6;
            this.buttonSuggestSymbols.Text = "Suggest Symbols";
            this.buttonSuggestSymbols.UseVisualStyleBackColor = true;
            this.buttonSuggestSymbols.Click += new System.EventHandler(this.buttonSuggestSymbols_Click);
            // 
            // FrmExtractFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 219);
            this.Controls.Add(this.buttonSuggestSymbols);
            this.Controls.Add(this.buttonConvertAndExport);
            this.Controls.Add(this.buttonAddSymbols);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSymbols);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmExtractFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmExtractFile";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.TextBox textBoxSymbols;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddSymbols;
        private System.Windows.Forms.Button buttonConvertAndExport;
        private System.Windows.Forms.Button buttonSuggestSymbols;
    }
}