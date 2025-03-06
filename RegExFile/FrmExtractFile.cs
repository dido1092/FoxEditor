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
    public partial class FrmExtractFile : Form
    {
        private string[] pathWithFile = { };
        private string pathToAddFiles = string.Empty;
        private char[] symbols = { };
        public FrmExtractFile()
        {
            InitializeComponent();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            GetPathFromDir();
        }
        public string[] GetPathFromDir()
        {
            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToAddFiles = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                pathWithFile = openFileDialog1.FileNames;
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

        private void buttonAddSymbols_Click(object sender, EventArgs e)
        {
            symbols = textBoxSymbols.Text.ToCharArray();
        }

        private void buttonConvertAndExport_Click(object sender, EventArgs e)
        {
            HashSet<string> hsWords = new HashSet<string>();

            string[] lines = System.IO.File.ReadAllLines(pathWithFile[0]);

            string getFullWord = string.Empty;
            string word = string.Empty;

            if (symbols.Length > 0)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];

                    if (line == "" || line == " ")
                    {
                        continue;
                    }
                    else
                    {
                        string[] arrLine = line.Split(symbols);

                        if (arrLine[arrLine.Length - 1] == "adj" || arrLine[arrLine.Length - 1] == "noun" || arrLine[arrLine.Length - 1] == "verb")
                        {
                            getFullWord = string.Empty;

                            for (int j = 0; j < arrLine.Length - 1; j++)
                            {
                                word = arrLine[j].ToUpper();
                                bool isDigit = false;

                                if (word.Length == 1)
                                {
                                    for (int l = 0; l < word.Length; l++)
                                    {
                                        if (Char.IsDigit(word[l]))
                                        {
                                            isDigit = true;
                                            break;
                                        }

                                    }
                                    if (isDigit == false)
                                    {
                                        word = word.Replace(" ", "");

                                        getFullWord += word;

                                        //hsWords.Add(word.Trim() + $" {arrLine[arrLine.Length - 1]}");
                                    }
                                }
                                else if (word.Length > 1)
                                {
                                    for (int l = 0; l < word.Length; l++)
                                    {
                                        if (Char.IsDigit(word[l]))
                                        {
                                            isDigit = true;
                                            break;
                                        }

                                    }
                                    if (isDigit == false)
                                    {
                                        //word = word.Replace(" ", "");

                                        getFullWord += word;

                                        //hsWords.Add(word.Trim() + $" {arrLine[arrLine.Length - 1]}");
                                    }
                                }
                            }
                            hsWords.Add(getFullWord.Trim() + $" {arrLine[arrLine.Length - 1]}");
                        }
                    }
                }


                string pathToDest = GetPathToDest();

                string[] getName = pathWithFile[0].Split('\\');

                File.WriteAllText(pathToDest + $"\\{getName[getName.Length - 1]}_EXTRACTED.txt", string.Join("\n", hsWords));

                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Enter symbols for split!");
            }
        }
        private string GetPathToDest()
        {
            string path = string.Empty;

            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            return path;
        }

        private void buttonSuggestSymbols_Click(object sender, EventArgs e)
        {
            textBoxSymbols.Text = " \t\r\n:,?()/+-.•~[]!#$%^&*_";
        }
    }
}
