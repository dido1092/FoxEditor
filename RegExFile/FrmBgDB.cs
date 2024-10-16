using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
//using static Org.BouncyCastle.Math.EC.ECCurve;

namespace RegExFile
{
    public partial class FrmBgDB : Form
    {
        private static SqlConnection cnn;
        private static SqlTransaction transaction;
        private static RegExFileContext context = new RegExFileContext();
        private static string query = string.Empty;

        public FrmBgDB()
        {
            InitializeComponent();

            cnn = new SqlConnection(DbConfig.ConnectionString);
            cnn.Open();
            //transaction = cnn.BeginTransaction();
        }

        private async void buttonExecute_Click(object sender, EventArgs e)
        {
            query = textBoxQuery.Text.ToUpper();

            await Execute(query);
        }
        private async Task Execute(string query)
        {
            if (query != "")
            {
                string connectionString = null;
                connectionString = DbConfig.ConnectionString;

                SqlConnection cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                int rowindex = dataGridViewBgDB.CurrentRow.Index;
                int colindex = dataGridViewBgDB.CurrentCell.ColumnIndex;

                string columnName = dataGridViewBgDB.Columns[colindex].HeaderText;

                string getValue = dataGridViewBgDB.CurrentCell.Value.ToString();
                string id = dataGridViewBgDB.Rows[rowindex].Cells[0].Value.ToString();

                cnn.Open();
                //transaction = cnn.BeginTransaction();
                try
                {
                    //if (query.Contains("SELECT"))
                    //{
                    SqlDataAdapter da = new SqlDataAdapter($"{query}", cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "BgWords");
                    dataGridViewBgDB.DataSource = ds.Tables["BgWords"];
                    //transaction.Commit();
                    cnn.Close();
                    MessageBox.Show("Success!");
                    //}
                }
                catch (Exception)
                {
                    MessageBox.Show("UnSuccess!");
                    //transaction.Rollback();
                }

                labelRows.Text = $"Rows: {dataGridViewBgDB.RowCount}";
            }
        }

        private static void Update(string connectionString, out SqlConnection cnn, out SqlCommand cmd, string columnName, string getValue, string id)
        {
            using (cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                string sqlCommand = $"Update BgWords set {columnName}=@{columnName} Where Id={id}";
                cmd = new SqlCommand(sqlCommand, cnn);
                cmd.Parameters.AddWithValue($"@{columnName}", getValue);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 1)
                {
                    MessageBox.Show("Information Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cnn.Close();
            }
        }

        private static void Delete(SqlConnection cnn, SqlCommand cmd, string id)
        {
            cmd.CommandText = ($"Delete From BgWords Where Id=" + id + "");
            cnn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The row has been deleted ! ");
            cnn.Close();
        }

        private async void buttonSelectCell_Click(object sender, EventArgs e)
        {
            int id = 0;

            id = Convert.ToInt32(dataGridViewBgDB.Rows[dataGridViewBgDB.CurrentRow.Index].Cells[0].Value);

            string query = @"SELECT * FROM BgWords WHERE Id = " + id;

            await Execute(query);

            textBoxQuery.Text = $"SELECT * FROM BgWords WHERE Id = {id}";
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await Refresh();
        }

        private async Task Refresh()
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            await cnn.OpenAsync();

            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM BgWords", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "BgWords");
            dataGridViewBgDB.DataSource = ds.Tables["BgWords"].DefaultView;

            labelRows.Text = $"Rows: {dataGridViewBgDB.RowCount}";
        }

        private void FrmBgDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foxTextEditorDataSet.BgWords' table. You can move, or remove it, as needed.
            this.bgWordsTableAdapter.Fill(this.foxTextEditorDataSet.BgWords);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewBgDB.CurrentRow.Index;
            int colindex = dataGridViewBgDB.CurrentCell.ColumnIndex;

            string columnName = dataGridViewBgDB.Columns[colindex].HeaderText;

            string getValue = dataGridViewBgDB.CurrentCell.Value.ToString();
            string id = dataGridViewBgDB.Rows[rowindex].Cells[0].Value.ToString();

            Delete(cnn, cmd, id);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewBgDB.CurrentRow.Index;
            int colindex = dataGridViewBgDB.CurrentCell.ColumnIndex;

            string columnName = dataGridViewBgDB.Columns[colindex].HeaderText;

            string getValue = dataGridViewBgDB.CurrentCell.Value.ToString();
            string id = dataGridViewBgDB.Rows[rowindex].Cells[0].Value.ToString();

            Update(connectionString, out cnn, out cmd, columnName, getValue, id);
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            transaction.Commit();
        }

        private void buttonRollback_Click(object sender, EventArgs e)
        {
            transaction.Rollback();
        }
    }
}
