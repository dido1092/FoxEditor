using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;
using System.Text.RegularExpressions;
using System.Text;
using System.Drawing;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using static iTextSharp.text.pdf.PdfDocument;
using iTextSharp.text;
using System.Runtime.InteropServices.ComTypes;
using pdftron.PDF;
using SixLabors.Fonts.Unicode;
using pdftron.SDF;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;
using SautinSoft.Document;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Controls;

namespace RegExFile
{
    public partial class Form1 : Form
    {
        private static string pathToAddFiles = string.Empty;
        private static string[] pathWithFile = { };
        private static int page = 1;
        private static int numPages = 0;
        private static string text = string.Empty;
        private static string name = string.Empty;
        private static string destination = string.Empty;

        public Form1()
        {
            InitializeComponent();

        }
        private void textBoxRegEx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxRegEx.TextAlignChanged += textBoxRegEx_TextChanged;

                richTextBoxFileWindow.Text = textBoxRegEx.Text;
            }
        }
        private void textBoxRegEx_TextChanged(object sender, EventArgs e)
        {
            //textBoxRegEx_KeyDown(textBoxRegEx, new KeyEventArgs(Keys.Enter));
        }

        private void buttonChoiceFile_Click(object sender, EventArgs e)
        {
            GetPath();
            ReadPdf(pathWithFile[0]);
        }
        public void ReadPdf(string filePath)
        {
            PdfReader reader = new PdfReader(filePath);

            numPages = reader.NumberOfPages;

            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            string pageContent = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

            richTextBoxFileWindow.Text = ($"\n{pageContent}");
            labelPages.Text = $"{page}/{numPages}";
            text = pageContent;

            reader.Close();
        }
        private string[] GetPath()
        {
            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToAddFiles = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                pathWithFile = openFileDialog1.FileNames;
            }

            return pathWithFile;
        }
        private static OpenFileDialog OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                InitialDirectory = @"C:\",
                Title = "Browse AudioVideo Files",

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

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                ReadPdf(pathWithFile[0]);
            }
            else
            {
                page = 1;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (page < numPages)
            {
                page++;
                ReadPdf(pathWithFile[0]);
            }
            else
            {
                page = numPages;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            string[] lines = text.Split(' ', '\n', '\t', '.', ',');

            string pattern = $"{textBoxRegEx.Text}";//.Replace(@"\s", "").Replace(@"\t", "").Replace(@"\n", "");

            foreach (var currentLine in lines)
            {
                Match match = Regex.Match(currentLine, pattern);

                while (match.Success)
                {
                    if (currentLine != "")
                    {
                        name = match.Groups[1].Value.ToLower();

                        int index = text.IndexOf(name);

                        if (index != 0 && index != -1)
                        {
                            System.Drawing.Font fnt = new System.Drawing.Font("Verdana", 8F, FontStyle.Bold, GraphicsUnit.Point);

                            richTextBoxFileWindow.Select(index + 1, name.Length);

                            richTextBoxFileWindow.SelectionFont = fnt;
                            richTextBoxFileWindow.SelectionColor = System.Drawing.Color.CadetBlue;
                            //richTextBoxFileWindow.SelectionColor = Color.Green;
                        }
                        match = match.NextMatch();
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDestination();

            labelDestination.Text = $"Destination: {destination}";
        }
        private void SaveDestination()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            string createText = richTextBoxFileWindow.Text;
            string extension = comboBoxExtension.Text.ToLower();
            if (extension == "" || extension == " ")
            {
                MessageBox.Show("Select extension!");
            }
            //else if (extension == "txt")
            //{
            //    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        destination = folderBrowserDialog1.SelectedPath + $"\\{page}.{extension}";
            //    }
            //    else
            //    {
            //        destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{page}.{extension}";
            //    }
            //    File.WriteAllText(destination, createText);
            //}
            else// if (extension == "pdf")
            {

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    destination = folderBrowserDialog1.SelectedPath + $"\\{page}.{extension}";
                }
                else
                {
                    destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{page}.{extension}";
                }

                DocumentCore dc = new DocumentCore();
                ContentRange cr = dc.Content;

                cr.Start.Insert(createText);
                dc.Save(destination);

                //cr = dc.Content.Find("SautinSoft.Document 2024.4.24 trial. Get your free 30-day key instantly: https://sautinsoft.com/start-for-free/").FirstOrDefault();
                //cr.Start.Insert("");
                //destination = folderBrowserDialog1.SelectedPath + $"\\Without logo {page}.{extension}";
                //dc.Save(destination);

                MessageBox.Show("Saved!");
            }
        }

        private void buttonSelectPege_Click(object sender, EventArgs e)
        {
            bool isNumber = false;

            isNumber = int.TryParse(textBoxPage.Text, out page);
            if (isNumber)
            {
                page = int.Parse(textBoxPage.Text);
                ReadPdf(pathWithFile[0]);
            }
        }

        private System.Windows.Forms.RichTextBox GetRichTextBoxFileWindow()
        {
            return richTextBoxFileWindow;
        }

        private void richTextBoxFileWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void hScrollBarFont_Scroll(object sender, ScrollEventArgs e)
        {
            // Get the current scrollbar value (e.g., between 6 and maximum)
            if (hScrollBarFont.Value > 6)
            {
                // Define your logic to calculate the new font size based on scrollValue
                float newFontSize = hScrollBarFont.Value;

                // Apply the new font size (entire content or selected text)
                richTextBoxFileWindow.Font = new System.Drawing.Font(richTextBoxFileWindow.Font.FontFamily, newFontSize);
            }
        }
    }
}
