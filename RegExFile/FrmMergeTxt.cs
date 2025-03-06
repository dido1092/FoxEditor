using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExFile
{
    public partial class FrmMergeTxt : Form
    {
        private List<string> lsContent = new List<string>();
        private StringBuilder sbMergedContent = new StringBuilder();

        private string pathToAddFiles = string.Empty;
        private string saveTo = string.Empty;

        private string[] pathWithFile = { };

        private string[] arrAllContents = { };
        public FrmMergeTxt()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            Clear();

            Open();

            ReadTxt();
        }

        private void ReadTxt()
        {
            int fileIndex = 0;


            foreach (string filePath in pathWithFile)
            {
                string content = string.Empty;

                var reader = new PageReadTxt(filePath);

                lsContent = reader.GetPages();

                if (fileIndex < pathWithFile.Length)
                {
                    foreach (string cont in lsContent)
                    {
                        content += cont;
                    }
                    //TxtPageContent txtPageContent = new TxtPageContent();
                    //txtPageContent.Content = content;

                    arrAllContents[fileIndex] = content;

                    fileIndex++;
                }

                richTextBoxResult.Text += string.Join("", lsContent);
                richTextBoxResult.Text += "\n";

                labelItems.Text = $"Items: {lsContent.Count * pathWithFile.Length}";
            }
        }

        public string[] Open()
        {
            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToAddFiles = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                pathWithFile = openFileDialog1.FileNames;

                arrAllContents = new string[pathWithFile.Length];

                textBoxPath.Text = pathToAddFiles;

                richTextBoxFiles.Text = string.Join("\n", pathWithFile);
            }
            else
            {
                pathWithFile = new string[0];
            }
            return pathWithFile;
        }
        private static OpenFileDialog OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Browse Doc Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "All Files",
                Filter = "All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                Multiselect = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            return openFileDialog1;
        }
        private void Clear()
        {
            richTextBoxResult.Clear();
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            if (comboBoxChoice.Text == "1=2" || comboBoxChoice.Text == "1>2" || comboBoxChoice.Text == "1<2")
            {
                sbMergedContent = new StringBuilder();

                string contentFirst = string.Empty;
                string contentSecond = string.Empty;

                richTextBoxResult.Text = "";

                int getBiggerLength = 0;

                if (checkBoxChange.Checked)
                {
                    contentFirst = arrAllContents[0];
                    contentSecond = arrAllContents[1];
                }
                else
                {
                    contentFirst = arrAllContents[1];
                    contentSecond = arrAllContents[0];
                }

                string[] arrContentFirst = contentFirst.Split('\n');

                string[] arrContentSecond = contentSecond.Split('\n');

                getBiggerLength = arrContentFirst.Length;

                for (int i = 0; i < getBiggerLength; i++)
                {
                    if (comboBoxChoice.Text == "1=2")
                    {
                        sbMergedContent.AppendLine($"{arrContentFirst[i].ToUpper()} <> {arrContentSecond[i].ToUpper()}");
                    }
                    else if (comboBoxChoice.Text == "1>2")
                    {
                        if (i % 2 == 0)
                        {
                            sbMergedContent.AppendLine(arrContentFirst[i].ToUpper());
                            sbMergedContent.AppendLine(arrContentSecond[i].ToUpper());
                        }
                        else
                        {
                            sbMergedContent.AppendLine(arrContentSecond[i].ToUpper());
                            sbMergedContent.AppendLine(arrContentFirst[i].ToUpper());
                        }
                    }
                    else if (comboBoxChoice.Text == "1<2")
                    {
                        if (i % 2 == 0)
                        {
                            sbMergedContent.AppendLine(arrContentSecond[i].ToUpper());
                            sbMergedContent.AppendLine(arrContentFirst[i].ToUpper());
                        }
                        else
                        {
                            sbMergedContent.AppendLine(arrContentFirst[i].ToUpper());
                            sbMergedContent.AppendLine(arrContentSecond[i].ToUpper());
                        }
                    }
                }

                richTextBoxResult.Text = string.Join("", sbMergedContent.ToString());
            }
        }

        private void comboBoxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();

            if (saveTo.Length > 0)
            {
                File.WriteAllText(saveTo, string.Join("\n", sbMergedContent));

                MessageBox.Show("Done!");
            }
        }
        private void Save()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            //savefile.InitialDirectory = "e:\\faktur";
            savefile.FileName = String.Format("{0}.txt", Text);
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = "TEXT Files|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName)) { }

                saveTo = savefile.FileName;

                labelSaveTo.Text = $"Path SaveTo: {savefile.FileName}";
            }
            else
            {
                saveTo = string.Empty;

                labelSaveTo.Text = $"Path SaveTo:";
            }
        }
    }
}
