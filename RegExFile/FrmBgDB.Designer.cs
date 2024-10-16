namespace RegExFile
{
    partial class FrmBgDB
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
            this.components = new System.ComponentModel.Container();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.dataGridViewBgDB = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgWordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foxTextEditorDataSet = new RegExFile.FoxTextEditorDataSet();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelRows = new System.Windows.Forms.Label();
            this.buttonSelectCell = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.bgWordsTableAdapter = new RegExFile.FoxTextEditorDataSetTableAdapters.BgWordsTableAdapter();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBgDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgWordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(34, 36);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxQuery.Size = new System.Drawing.Size(433, 41);
            this.textBoxQuery.TabIndex = 0;
            // 
            // dataGridViewBgDB
            // 
            this.dataGridViewBgDB.AutoGenerateColumns = false;
            this.dataGridViewBgDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBgDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bgWordDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridViewBgDB.DataSource = this.bgWordsBindingSource;
            this.dataGridViewBgDB.Location = new System.Drawing.Point(34, 140);
            this.dataGridViewBgDB.Name = "dataGridViewBgDB";
            this.dataGridViewBgDB.Size = new System.Drawing.Size(550, 525);
            this.dataGridViewBgDB.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bgWordDataGridViewTextBoxColumn
            // 
            this.bgWordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bgWordDataGridViewTextBoxColumn.DataPropertyName = "BgWord";
            this.bgWordDataGridViewTextBoxColumn.HeaderText = "BgWord";
            this.bgWordDataGridViewTextBoxColumn.Name = "bgWordDataGridViewTextBoxColumn";
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // bgWordsBindingSource
            // 
            this.bgWordsBindingSource.DataMember = "BgWords";
            this.bgWordsBindingSource.DataSource = this.foxTextEditorDataSet;
            // 
            // foxTextEditorDataSet
            // 
            this.foxTextEditorDataSet.DataSetName = "FoxTextEditorDataSet";
            this.foxTextEditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(473, 36);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(111, 41);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(34, 672);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(37, 13);
            this.labelRows.TabIndex = 3;
            this.labelRows.Text = "Rows:";
            // 
            // buttonSelectCell
            // 
            this.buttonSelectCell.Location = new System.Drawing.Point(34, 111);
            this.buttonSelectCell.Name = "buttonSelectCell";
            this.buttonSelectCell.Size = new System.Drawing.Size(91, 23);
            this.buttonSelectCell.TabIndex = 4;
            this.buttonSelectCell.Text = "Select Cell";
            this.buttonSelectCell.UseVisualStyleBackColor = true;
            this.buttonSelectCell.Click += new System.EventHandler(this.buttonSelectCell_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(605, 36);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 41);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // bgWordsTableAdapter
            // 
            this.bgWordsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(605, 636);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(96, 29);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(605, 140);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 29);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Query";
            // 
            // FrmBgDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 701);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSelectCell);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.dataGridViewBgDB);
            this.Controls.Add(this.textBoxQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmBgDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBgDB";
            this.Load += new System.EventHandler(this.FrmBgDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBgDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgWordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.DataGridView dataGridViewBgDB;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Button buttonSelectCell;
        private System.Windows.Forms.Button buttonRefresh;
        private FoxTextEditorDataSet foxTextEditorDataSet;
        private System.Windows.Forms.BindingSource bgWordsBindingSource;
        private FoxTextEditorDataSetTableAdapters.BgWordsTableAdapter bgWordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
    }
}