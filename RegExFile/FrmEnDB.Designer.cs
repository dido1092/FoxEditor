namespace RegExFile
{
    partial class FrmEnDB
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
            this.dataGridViewEnDB = new System.Windows.Forms.DataGridView();
            this.foxTextEditorDataSet = new RegExFile.FoxTextEditorDataSet();
            this.foxTextEditorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foxTextEditorDataSet1 = new RegExFile.FoxTextEditorDataSet1();
            this.enWordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enWordsTableAdapter = new RegExFile.FoxTextEditorDataSet1TableAdapters.EnWordsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelRows = new System.Windows.Forms.Label();
            this.buttonSelectCell = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enWordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEnDB
            // 
            this.dataGridViewEnDB.AutoGenerateColumns = false;
            this.dataGridViewEnDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.enWordDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn});
            this.dataGridViewEnDB.DataSource = this.enWordsBindingSource;
            this.dataGridViewEnDB.Location = new System.Drawing.Point(34, 140);
            this.dataGridViewEnDB.Name = "dataGridViewEnDB";
            this.dataGridViewEnDB.Size = new System.Drawing.Size(550, 525);
            this.dataGridViewEnDB.TabIndex = 0;
            // 
            // foxTextEditorDataSet
            // 
            this.foxTextEditorDataSet.DataSetName = "FoxTextEditorDataSet";
            this.foxTextEditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foxTextEditorDataSetBindingSource
            // 
            this.foxTextEditorDataSetBindingSource.DataSource = this.foxTextEditorDataSet;
            this.foxTextEditorDataSetBindingSource.Position = 0;
            // 
            // foxTextEditorDataSet1
            // 
            this.foxTextEditorDataSet1.DataSetName = "FoxTextEditorDataSet1";
            this.foxTextEditorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enWordsBindingSource
            // 
            this.enWordsBindingSource.DataMember = "EnWords";
            this.enWordsBindingSource.DataSource = this.foxTextEditorDataSet1;
            // 
            // enWordsTableAdapter
            // 
            this.enWordsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enWordDataGridViewTextBoxColumn
            // 
            this.enWordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.enWordDataGridViewTextBoxColumn.DataPropertyName = "EnWord";
            this.enWordDataGridViewTextBoxColumn.HeaderText = "EnWord";
            this.enWordDataGridViewTextBoxColumn.Name = "enWordDataGridViewTextBoxColumn";
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
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(34, 36);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(433, 41);
            this.textBoxQuery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Query";
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(473, 36);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(111, 41);
            this.buttonExecute.TabIndex = 3;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(31, 668);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(37, 13);
            this.labelRows.TabIndex = 4;
            this.labelRows.Text = "Rows:";
            // 
            // buttonSelectCell
            // 
            this.buttonSelectCell.Location = new System.Drawing.Point(34, 111);
            this.buttonSelectCell.Name = "buttonSelectCell";
            this.buttonSelectCell.Size = new System.Drawing.Size(91, 23);
            this.buttonSelectCell.TabIndex = 5;
            this.buttonSelectCell.Text = "Select Cell";
            this.buttonSelectCell.UseVisualStyleBackColor = true;
            this.buttonSelectCell.Click += new System.EventHandler(this.buttonSelectCell_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(605, 36);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 41);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(605, 140);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 29);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            // FrmEnDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 701);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSelectCell);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.dataGridViewEnDB);
            this.Name = "FrmEnDB";
            this.Text = "FrmEnDB";
            this.Load += new System.EventHandler(this.FrmEnDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foxTextEditorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enWordsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEnDB;
        private System.Windows.Forms.BindingSource foxTextEditorDataSetBindingSource;
        private FoxTextEditorDataSet foxTextEditorDataSet;
        private FoxTextEditorDataSet1 foxTextEditorDataSet1;
        private System.Windows.Forms.BindingSource enWordsBindingSource;
        private FoxTextEditorDataSet1TableAdapters.EnWordsTableAdapter enWordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Button buttonSelectCell;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}