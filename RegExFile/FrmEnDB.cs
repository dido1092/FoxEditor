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

namespace RegExFile
{
    public partial class FrmEnDB : Form
    {
        private static SqlConnection cnn;
        private static SqlTransaction transaction;
        private static RegExFileContext context = new RegExFileContext();
        private static string query = string.Empty;
        public FrmEnDB()
        {
            InitializeComponent();

            cnn = new SqlConnection(DbConfig.ConnectionString);
            cnn.Open();
        }

        private void FrmEnDB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foxTextEditorDataSet1.EnWords' table. You can move, or remove it, as needed.
            this.enWordsTableAdapter.Fill(this.foxTextEditorDataSet1.EnWords);

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

                int rowindex = dataGridViewEnDB.CurrentRow.Index;
                int colindex = dataGridViewEnDB.CurrentCell.ColumnIndex;

                string columnName = dataGridViewEnDB.Columns[colindex].HeaderText;

                string getValue = dataGridViewEnDB.CurrentCell.Value.ToString();
                string id = dataGridViewEnDB.Rows[rowindex].Cells[0].Value.ToString();

                cnn.Open();
                //transaction = cnn.BeginTransaction();
                try
                {
                    //if (query.Contains("SELECT"))
                    //{
                    SqlDataAdapter da = new SqlDataAdapter($"{query}", cnn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "EnWords");
                    dataGridViewEnDB.DataSource = ds.Tables["EnWords"];
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

                labelRows.Text = $"Rows: {dataGridViewEnDB.RowCount}";
            }
        }

        private async void buttonSelectCell_Click(object sender, EventArgs e)
        {
            int id = 0;

            id = Convert.ToInt32(dataGridViewEnDB.Rows[dataGridViewEnDB.CurrentRow.Index].Cells[0].Value);

            string query = @"SELECT * FROM EnWords WHERE Id = " + id;

            await Execute(query);

            textBoxQuery.Text = $"SELECT * FROM EnWords WHERE Id = {id}";
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await Refresh();
        }
        private async Task Refresh()
        {
            SqlConnection cnn = new SqlConnection(DbConfig.ConnectionString);
            await cnn.OpenAsync();

            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM EnWords", cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "EnWords");
            dataGridViewEnDB.DataSource = ds.Tables["EnWords"].DefaultView;

            labelRows.Text = $"Rows: {dataGridViewEnDB.RowCount}";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewEnDB.CurrentRow.Index;
            int colindex = dataGridViewEnDB.CurrentCell.ColumnIndex;

            string columnName = dataGridViewEnDB.Columns[colindex].HeaderText;

            string getValue = dataGridViewEnDB.CurrentCell.Value.ToString();
            string id = dataGridViewEnDB.Rows[rowindex].Cells[0].Value.ToString();

            Update(connectionString, out cnn, out cmd, columnName, getValue, id);
        }
        private static void Update(string connectionString, out SqlConnection cnn, out SqlCommand cmd, string columnName, string getValue, string id)
        {
            using (cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                string sqlCommand = $"Update EnWords set {columnName}=@{columnName} Where Id={id}";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = DbConfig.ConnectionString;

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            int rowindex = dataGridViewEnDB.CurrentRow.Index;
            int colindex = dataGridViewEnDB.CurrentCell.ColumnIndex;

            string columnName = dataGridViewEnDB.Columns[colindex].HeaderText;

            string getValue = dataGridViewEnDB.CurrentCell.Value.ToString();
            string id = dataGridViewEnDB.Rows[rowindex].Cells[0].Value.ToString();

            Delete(cnn, cmd, id);
        }
        private static void Delete(SqlConnection cnn, SqlCommand cmd, string id)
        {
            cmd.CommandText = ($"Delete From EnWords Where Id=" + id + "");
            cnn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("The row has been deleted ! ");
            cnn.Close();
        }
    }
}
