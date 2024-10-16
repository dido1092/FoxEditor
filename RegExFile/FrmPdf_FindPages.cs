using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace RegExFile
{
    public partial class FrmPdf_FindPages : Form
    {
        private static string pathToAddFiles = string.Empty;
        public string[] pathWithFileFindPdfPage = { };
        public string pageContent = string.Empty;
        private static List<RememberText> lsPdfPagesText;
        private bool isOpen;
        private RichTextBox richTBox = new RichTextBox();
        private System.Windows.Forms.TextBox TextBoxPage = new TextBox();
        private List<FindedWord> lsFindedWord;
        private int page;
        private static FrmPdf_FindPages instance;
        private Form1 form1;
        private int indexCounter = 0;
        private string filePath;

        public FrmPdf_FindPages(RichTextBox richBox, TextBox textBoxPageForm1, int pageForm1, string filePath)
        {
            InitializeComponent();

            instance = this;
            lsPdfPagesText = new List<RememberText>();
            isOpen = false;
            richTBox = richBox;
            lsFindedWord = new List<FindedWord>();
            form1 = new Form1();
            TextBoxPage = textBoxPageForm1;
            page = pageForm1;
            this.filePath = filePath;
            //GetPdfPageText(form1.pathWithFile[0]);
            //Open();
        }

        //private void buttonOpen_Click(object sender, EventArgs e)
        //{
        //    Clear();

        //    GetPath();

        //    if (pathWithFile.Count() > 0)
        //    {
        //        if (pathWithFile[0].Contains(".pdf"))
        //        {
        //            GetPdfPageText(pathWithFile[0]);
        //        }
        //    }
        //}

        private void Clear()
        {
            textBoxPages.Text = "";

            lsFindedWord.Clear();

        }

        public List<RememberText> GetPdfPageText(string filePath)
        {
            PdfReader reader = new PdfReader(filePath);

            int numPages = reader.NumberOfPages;

            for (int page = 1; page <= numPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                pageContent = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

                RememberText rememberText = new RememberText();
                rememberText.PageNum = page;
                rememberText.Text = pageContent;

                lsPdfPagesText.Add(rememberText);
            }

            reader.Close();

            return lsPdfPagesText;
        }
        public string[] GetPath()
        {
            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToAddFiles = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                pathWithFileFindPdfPage = openFileDialog1.FileNames;
            }
            else
            {
                pathWithFileFindPdfPage = new string[0];
            }
            return pathWithFileFindPdfPage;
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

        private void buttonFindWord_Click(object sender, EventArgs e)
        {
            Clear();

            //if (isOpen)
            //{
            if (textBoxFindWord.Text != "")
            {
                HashSet<int> hsPages = new HashSet<int>();
                List<RememberText> lsPdfTex = GetPdfPageText(filePath);
                //StringBuilder sbConvertToCyrillic = new StringBuilder();                  

                int countSpaces = 0;
                int countLetter = 0;
                string findedWord = string.Empty;
                string modelWord = string.Empty;

                string searchedWord = textBoxFindWord.Text.Replace(" ", "");
                string letterFromSearchWord = searchedWord[0].ToString().ToLower();

                foreach (var pageText in lsPdfTex)
                //foreach (var pageText in lsPdfPagesText)
                //foreach (var pageText in sbConvertToCyrillic.ToString())
                {
                    //string text = pageText.Text;
                    string text = form1.ConvertToCyrillic(pageText.Text).ToString();
                    //string text = sbConvertToCyrillic.ToString();

                    for (int i = 0; i < text.Length; i++)
                    {
                        string letterFromText = text[i].ToString().ToLower();

                        if (letterFromText == letterFromSearchWord)
                        {
                            modelWord = "";
                            findedWord = "";
                            countSpaces = 0;
                            countLetter = 0;

                            for (int k = i; k < (i + searchedWord.Length + countSpaces); k++)
                            {
                                if (k < text.Length - 1)
                                {
                                    string getLetter = text[k].ToString().Replace(" ", "");

                                    if (getLetter == "")
                                    {
                                        findedWord += " ";
                                        countSpaces++;
                                    }
                                    else if (getLetter == "-")
                                    {
                                        findedWord += "-";
                                        countSpaces++;
                                        continue;
                                    }
                                    else
                                    {
                                        if (searchedWord[countLetter].ToString().ToUpper() == getLetter[0].ToString().ToUpper())
                                        {
                                            countLetter++;

                                            bool isUpper = char.IsUpper(getLetter[0]);

                                            if (isUpper)
                                            {
                                                modelWord += getLetter[0].ToString().ToUpper();
                                                findedWord += getLetter[0];
                                            }
                                            else
                                            {
                                                modelWord += getLetter[0].ToString().ToLower();
                                                findedWord += getLetter[0];
                                            }
                                            if (countLetter == searchedWord.Length)
                                            {
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if (modelWord.ToLower() == searchedWord.ToLower())
                            {
                                FindedWord objFindedWord = new FindedWord();

                                objFindedWord.Page = pageText.PageNum;

                                objFindedWord.Index = i;
                                //objFindedWord.Index = text.IndexOf(searchedWord, indexCounter);
                                indexCounter += objFindedWord.Index;
                                indexCounter++;
                                objFindedWord.Length = findedWord.Length;

                                lsFindedWord.Add(objFindedWord);

                                hsPages.Add(pageText.PageNum);

                                i += searchedWord.Length;
                            }
                        }
                    }
                }
                textBoxPages.Text = "";

                if (hsPages.Count() > 0)
                {
                    foreach (var page in hsPages)
                    {
                        textBoxPages.Text += page + Environment.NewLine;
                    }
                }
                else
                {
                    MessageBox.Show("No Word Founded!");
                }
            }
            else
            {
                MessageBox.Show("Enter word!");
            }
            //}
            //else
            //{
            //    MessageBox.Show("Open file!");
            //}
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            //isOpen = true;

            //Open();
        }

        //private void Open()
        //{
        //    textBoxPages.Text = "";

        //    GetPath();

        //    if (pathWithFileFindPdfPage.Count() > 0)
        //    {
        //        if (pathWithFileFindPdfPage[0].Contains(".pdf"))
        //        {
        //            form1.extension = ".pdf";
        //            GetPdfPageText(pathWithFileFindPdfPage[0]);
        //        }
        //    }

        //    labelPath.Text = $"Status: Ready!";
        //}

        private void buttonView_Click(object sender, EventArgs e)
        {
            int getPage = 0;


            bool isInteger = Int32.TryParse(textBoxPages.SelectedText, out getPage);

            if (isInteger)
            {
                var getText = lsPdfPagesText.Select(x => new { x.PageNum, x.Text }).Where(p => p.PageNum == getPage).FirstOrDefault();

                var convertedText = form1.ConvertToCyrillic(getText.Text).ToString();

                richTBox.Text = string.Join("\n", convertedText);

                foreach (var word in lsFindedWord.Where(p => p.Page == getPage))
                {
                    richTBox.Select(word.Index, word.Length);
                    //richTBox.SelectionColor = System.Drawing.Color.RoyalBlue;
                    richTBox.SelectionColor = System.Drawing.Color.Red;
                }

                form1.page = getPage;

                TextBoxPage.Text = getPage.ToString();

                labelSelectedPage.Text = $"Page: {getPage}";

            }
            else
            {
                MessageBox.Show("Select One Character!");
            }
        }
    }
}
