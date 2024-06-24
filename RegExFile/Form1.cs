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
using System.Drawing.Text;
using System.Web.UI.WebControls;
using static pdftron.PDF.Page;
using System.Web.WebSockets;

namespace RegExFile
{
    public partial class Form1 : Form
    {
        private const char Separator = ' ';
        private static string pathToAddFiles = string.Empty;
        private static string[] pathWithFile = { };
        private static int page = 1;
        private static int numPages = 0;
        private static string text = string.Empty;
        private static string name = string.Empty;
        private static string destination = string.Empty;
        private static string createText = string.Empty;
        public static HashSet<RememberText> hsRememberText = new HashSet<RememberText>();
        private System.Windows.Forms.Timer autosaveTimer;
        public static string extension = string.Empty;
        //public string _myRichTextBox = string.Empty;
        public string pageContent = string.Empty;
        private List<string> lsGetToUpperContent = new List<string>();
        private List<string> lsGetToLowerContent = new List<string>();

        //public static string textPassedForm1;
        //Form1 form1 { get; set; }
        //PageReadTxt pageReadTxt = new PageReadTxt(pathWithFile[0]);
        public Form1()
        {
            InitializeComponent();
            PopulateFontComboBox(comboBoxFont);
            //MyRichTextBox = richTextBoxFileWindow;

        }
        //public Form1(string text)
        //{
        //    this._myRichTextBox = text;
        //    //richTextBoxFileWindow.Text = "";
        //    //if (richTextBoxFileWindow.Text == "")
        //    //{
        //    //this.richTextBoxFileWindow.Text = text;
        //    //}
        //}
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    if (_myRichTextBox != null)
        //    {
        //        richTextBoxFileWindow.Text = _myRichTextBox;
        //    }
        //    else
        //    {
        //        richTextBoxFileWindow.Text = pageContent;
        //    }
        //}
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
            Clear();

            GetPath();

            if (pathWithFile[0].Contains(".pdf"))
            {
                page = 1;
                extension = "pdf";
                ReadPdf(pathWithFile[0]);
            }
            else if (pathWithFile[0].Contains(".txt"))
            {
                page = 0;
                extension = "txt";
                ReadTxt(pathWithFile[0]);
            }
        }

        private void Clear()
        {
            textBoxPage.Text = "";
            textBoxRememberText.Text = "";
            hsRememberText.Clear();
            comboBoxExtension.Text = "";
            checkBoxAutoSave.Checked = false;
            checkBoxRememberText.Checked = false;
            checkBoxSaveAllPages.Checked = false;
            checkBoxForAllDocument.Checked = false;
            lsGetToLowerContent.Clear();
            lsGetToUpperContent.Clear();
            destination = string.Empty;
            createText = string.Empty;
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
        public void ReadPdf(string filePath)
        {
            if (page == 0)
            {
                page = 1;
            }
            PdfReader reader = new PdfReader(filePath);

            numPages = reader.NumberOfPages;

            ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            pageContent = PdfTextExtractor.GetTextFromPage(reader, page, strategy);

            richTextBoxFileWindow.Text = ($"\n{pageContent}");
            labelPages.Text = $"{page}/{numPages}";
            text = pageContent;

            reader.Close();
        }
        public void ReadTxt(string filePath)
        {
            int pageSize = 40;
            var reader = new PageReadTxt(filePath);
            richTextBoxFileWindow.Text = "";

            List<string> lsContent = new List<string>();
            lsContent = reader.GetPages();
            int count = 0;
            numPages = lsContent.Count();

            if (checkBoxForAllDocument.Checked && lsGetToUpperContent.Count > 0)
            {
                richTextBoxFileWindow.Text = "";
            }

            DisplayPages(pageSize, lsContent, count);

            textBoxPage.Text = $"{page}";
            labelPages.Text = $"{page}/{numPages / 40}";
        }

        private void DisplayPages(int pageSize, List<string> lsContent, int count)
        {
            for (int line = page * pageSize; line < numPages; line++)
            {
                if (count == pageSize)
                {
                    break;
                }

                if (checkBoxForAllDocument.Checked && lsGetToUpperContent.Count > 0)
                {
                    richTextBoxFileWindow.Text += lsGetToUpperContent[line];
                }
                else if (checkBoxForAllDocument.Checked && lsGetToLowerContent.Count > 0)
                {
                    richTextBoxFileWindow.Text += lsGetToLowerContent[line];
                }
                else
                {
                    richTextBoxFileWindow.Text += lsContent[line];
                }

                count++;
            }
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
            if (page > 0)
            {
                page--;

                if (extension == "pdf")
                {
                    ReadPdf(pathWithFile[0]);
                }
                else if (extension == "txt")
                {
                    ReadTxt(pathWithFile[0]);
                }
            }
            else
            {
                page = 0;
            }
            if (extension == "pdf")
            {
                textBoxPage.Text = $"{page}";
            }
            else if (extension == "txt")
            {
                textBoxPage.Text = $"{page}";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (extension == "pdf")
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
            else if (extension == "txt")
            {
                if (page < (numPages / 40))// - 1)
                {
                    page++;
                    ReadTxt(pathWithFile[0]);
                }
                else
                {
                    page = (numPages / 40); // - 1;
                }
            }
            if (extension == "pdf")
            {
                textBoxPage.Text = $"{page}";
            }
            else if (extension == "txt")
            {
                textBoxPage.Text = $"{page}";
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

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (checkBoxSaveAllPages.Checked && extension == "pdf")
                {
                    PdfReader reader = new PdfReader(pathWithFile[0]);

                    numPages = reader.NumberOfPages;

                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    progressBarSaveAllPages.Minimum = 1;
                    progressBarSaveAllPages.Maximum = numPages;

                    for (int pageNum = 1; pageNum <= numPages; pageNum++)
                    {
                        createText = PdfTextExtractor.GetTextFromPage(reader, pageNum, strategy);
                        progressBarSaveAllPages.Value = pageNum;
                    }
                }
                else if (checkBoxSaveAllPages.Checked && extension == "txt")
                {
                    PageReadTxt reader = new PageReadTxt(pathWithFile[0]);

                    if (lsGetToUpperContent.Count > 0)
                    {
                        foreach (var page in lsGetToUpperContent)
                        {
                            createText += page;
                        }
                    }
                    else if (lsGetToLowerContent.Count > 0)
                    {
                        foreach (var page in lsGetToLowerContent)
                        {
                            createText += page;
                        }
                    }
                }
                else
                {
                    createText = richTextBoxFileWindow.Text;
                }
                if (checkBoxRememberText.Checked)
                {
                    createText = "";

                    foreach (var text in hsRememberText.OrderBy(page => page.PageNum))
                    {
                        createText += Environment.NewLine + $" ===================================  {text.PageNum}  ===================================  " + Environment.NewLine + Environment.NewLine + $"{text.Text}" + Environment.NewLine;
                    }
                }
                extension = comboBoxExtension.Text.ToLower();
                if (extension == "" || extension == " ")
                {
                    MessageBox.Show("Select extension!");
                }
                else
                {
                    //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    //{
                    if (checkBoxSaveAllPages.Checked)
                    {
                        if (extension == "pdf" && lsGetToUpperContent.Count > 0)
                        {
                            destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}_Modified_ToUpper.{extension}";//Take only name and extension
                        }
                        else if (extension == "pdf" && lsGetToLowerContent.Count > 0)
                        {
                            destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}_Modified__ToLower.{extension}";//Take only name and extension

                        }
                        if (extension == "txt" && lsGetToUpperContent.Count > 0)
                        {
                            destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".txt", ""))}_Modified_ToUpper.{extension}";//Take only name and extension
                        }
                        else if (extension == "txt" && lsGetToLowerContent.Count > 0)
                        {
                            destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".txt", ""))}_Modified_ToLower.{extension}";//Take only name and extension
                        }
                    }
                    else
                    {
                        destination = folderBrowserDialog1.SelectedPath + $"\\{page}.{extension}";

                        //if (extension == "pdf")
                        //{
                        //    destination = folderBrowserDialog1.SelectedPath + $"\\{page}.{extension}";
                        //}
                        //else if (extension == "txt")
                        //{
                        //    //destination = folderBrowserDialog1.SelectedPath + $"\\{page + 1}.{extension}";
                        //}
                    }
                    if (checkBoxRememberText.Checked)
                    {
                        if (extension == "pdf")
                        {
                            destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                        }
                        else if (extension == "txt")
                        {
                            //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.Select(pn => pn.PageNum + 1))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                            destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".txt", ""))}.{extension}";//Take only name and extension
                        }
                    }
                    //}
                    else
                    {
                        //if (checkBoxSaveAllPages.Checked)
                        //{
                        //    destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Modified_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";
                        //}
                        //else
                        //{
                        //    if (extension == "pdf")
                        //    {
                        //        destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{page}.{extension}";
                        //    }
                        //    else if (extension == "txt")
                        //    {
                        //        //destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{page + 1}.{extension}";
                        //        destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{page}.{extension}";
                        //    }
                        //}
                        if (checkBoxRememberText.Checked)
                        {
                            if (extension == "pdf")
                            {
                                destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Modified__{string.Join(" ", hsRememberText.Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";
                            }
                            else if (extension == "txt")
                            {
                                //destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Modified__{string.Join(" ", hsRememberText.Select(pn => pn.PageNum + 1))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";
                                destination = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\Modified__{string.Join(" ", hsRememberText.Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".txt", ""))}.{extension}";
                            }
                        }
                    }
                }
                if (!File.Exists(destination))
                {
                    DocumentCore dc = new DocumentCore();
                    ContentRange cr = dc.Content;

                    cr.Start.Insert(createText);
                    dc.Save(destination);

                    //cr = dc.Content.Find("SautinSoft.Document 2024.4.24 trial. Get your free 30-day key instantly: https://sautinsoft.com/start-for-free/").FirstOrDefault();
                    //cr.Start.Insert("");
                    //destination = folderBrowserDialog1.SelectedPath + $"\\Without logo {page}.{extension}";
                    //dc.Save(destination);

                    Clear();

                    MessageBox.Show("Saved!");
                }
                else
                {
                    MessageBox.Show("File Exist! NOT SAVED!!!");
                }
            }
        }
        private void buttonSelectPege_Click(object sender, EventArgs e)
        {
            bool isNumber = false;

            isNumber = int.TryParse(textBoxPage.Text, out page);

            if (isNumber)
            {
                page = int.Parse(textBoxPage.Text);// - 1;

                if (extension == "pdf")
                {
                    ReadPdf(pathWithFile[0]);
                }
                else if (extension == "txt")
                {
                    ReadTxt(pathWithFile[0]);
                }
            }
        }

        private System.Windows.Forms.RichTextBox GetRichTextBoxFileWindow()
        {
            return richTextBoxFileWindow;
        }

        public void richTextBoxFileWindow_TextChanged(object sender, EventArgs e)
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

        private void buttonRemoveSpaces_Click(object sender, EventArgs e)
        {
            if (richTextBoxFileWindow.SelectedText != "")
            {
                string[] removeSpaces = richTextBoxFileWindow.SelectedText.Split(' ');
                string newWord = string.Empty;
                for (int i = 0; i < removeSpaces.Length; i++)
                {
                    newWord += removeSpaces[i].Replace(" ", "");
                }
                richTextBoxFileWindow.SelectedText = newWord;
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
        }

        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            if (richTextBoxFileWindow.SelectedText != "")
            {
                string selectedText = richTextBoxFileWindow.SelectedText.ToUpper();

                if (checkBoxForAllDocument.Checked)
                {
                    richTextBoxFileWindow.Text = "";
                    int pageSize = 40;
                    int count = 0;

                    var reader = new PageReadTxt(pathWithFile[0]);
                    List<string> lsContent = new List<string>();
                    lsContent = reader.GetPages();

                    foreach (var page in lsContent)
                    {
                        lsGetToUpperContent.Add(page.ToString().ToUpper());
                    }
                    DisplayPages(pageSize, lsGetToUpperContent, count);
                }
                else
                {
                    richTextBoxFileWindow.SelectedText = selectedText;
                }
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
        }
        private void buttonToLower_Click(object sender, EventArgs e)
        {
            if (richTextBoxFileWindow.SelectedText != "")
            {
                string selectedText = richTextBoxFileWindow.SelectedText.ToLower();

                if (checkBoxForAllDocument.Checked)
                {
                    richTextBoxFileWindow.Text = "";
                    int pageSize = 40;
                    int count = 0;

                    var reader = new PageReadTxt(pathWithFile[0]);
                    List<string> lsContent = new List<string>();
                    lsContent = reader.GetPages();

                    foreach (var page in lsContent)
                    {
                        lsGetToLowerContent.Add(page.ToString().ToLower());
                    }
                    DisplayPages(pageSize, lsGetToUpperContent, count);
                }
                else
                {
                    richTextBoxFileWindow.SelectedText = selectedText;
                }
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
        }
        private void buttonAbv_Click(object sender, EventArgs e)
        {
            string word = richTextBoxFileWindow.SelectedText;

            string newWord = word[0].ToString().ToUpper();//First letter toUpper
            newWord += word.Substring(1, word.Length - 1).ToLower();//Other letters toLower

            richTextBoxFileWindow.SelectedText = newWord;
        }
        private void buttonRememberText_Click_1(object sender, EventArgs e)
        {
            RememberText();
        }

        private void RememberText()
        {
            RememberText rememberText = new RememberText();

            rememberText.PageNum = page;
            rememberText.Text = richTextBoxFileWindow.Text;

            var previuosEqualPage = hsRememberText.Where(pn => pn.PageNum == page && pn.Text != richTextBoxFileWindow.Text).FirstOrDefault();

            if (previuosEqualPage != null)
            {
                hsRememberText.Remove(previuosEqualPage);
            }
            hsRememberText.Add(rememberText);

            if (!textBoxRememberText.Text.Contains(page.ToString()))
            {
                if (extension == "pdf")
                {
                    textBoxRememberText.Text += page + " \t";
                }
                else if (extension == "txt")
                {
                    //page++;
                    textBoxRememberText.Text += page + " \t";
                    //page = int.Parse(textBoxRememberText.Text);
                }
            }
            else
            {
                MessageBox.Show("The Page is Overwrode!");
            }
            hsRememberText.OrderBy(x => x);
        }

        private void checkBoxSaveAllPages_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxRememberText.Checked = false;
        }

        private void checkBoxRememberText_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSaveAllPages.Checked = false;
        }

        private void buttonLoadRememberPage_Click(object sender, EventArgs e)
        {
            int remPage = int.Parse(textBoxRememberText.SelectedText);
            page = remPage;
            if (extension == "pdf")
            {
                ReadPdf(pathWithFile[0]);
            }
            else if (extension == "txt")
            {
                ReadTxt(pathWithFile[0]);
            }

            var remText = hsRememberText.Select(t => new { t.Text, t.PageNum }).Where(t => t.PageNum == remPage).FirstOrDefault();

            if (remText != null)
            {
                richTextBoxFileWindow.Text = remText.Text;
            }
        }
        private void buttonRemovePage_Click(object sender, EventArgs e)
        {
            string[] pages = textBoxRememberText.Text.Split();
            string newText = string.Empty;
            int currentPage = 0;
            int lastPageBuffer = 0;

            int selectedPage = int.Parse(textBoxRememberText.SelectedText);
            RememberText rm = new RememberText() { PageNum = selectedPage };

            hsRememberText.Remove(rm);

            for (int i = 0; i < pages.Length; i++)
            {
                if (pages[i] != "")
                {
                    currentPage = int.Parse(pages[i]);
                }
                if ((currentPage != selectedPage) && (currentPage != lastPageBuffer))
                {
                    newText += currentPage + Environment.NewLine;
                }

                lastPageBuffer = currentPage;
            }

            textBoxRememberText.Text = newText;
        }

        private void buttonRemoveEquals_Click(object sender, EventArgs e)
        {
            char[] symbols = richTextBoxFileWindow.SelectedText.ToCharArray();
            string allText = richTextBoxFileWindow.Text;
            string text = string.Empty;

            if (symbols.Length == 1)
            {
                for (int i = 0; i < allText.Length; i++)
                {
                    for (int j = 0; j < symbols.Length; j++)
                    {
                        if (allText[i] != symbols[j])
                        {
                            text += allText[i];
                        }
                    }
                }
                richTextBoxFileWindow.Text = text;
            }
            else
            {
                MessageBox.Show("Select One Symbol!");
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = (string)comboBoxFont.SelectedItem;

            richTextBoxFileWindow.Font = new System.Drawing.Font(selectedFontName, richTextBoxFileWindow.SelectionFont.Size, richTextBoxFileWindow.SelectionFont.Style);
        }
        private void PopulateFontComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            var fontCollection = new InstalledFontCollection();
            var fontFamilies = fontCollection.Families;

            foreach (var fontFamily in fontFamilies)
            {
                comboBoxFont.Items.Add(fontFamily.Name);
            }
        }
        private void checkBoxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxFileWindow.Text == "")
            {
                checkBoxAutoSave.Checked = false;
                MessageBox.Show("Open File!");
                return;
            }
            if (checkBoxAutoSave.Checked && comboBoxMin.Text != "")
            {
                autosaveTimer = new System.Windows.Forms.Timer();
                autosaveTimer.Interval = int.Parse(comboBoxMin.Text) * 60000; // 60000 = 1 minute interval
                autosaveTimer.Tick += buttonRememberText_Click_1;
                autosaveTimer.Start();
            }
            else
            {
                checkBoxAutoSave.Checked = false;
                MessageBox.Show("Enter minutes!");
                return;
            }
        }

        private void buttonFindForm_Click(object sender, EventArgs e)
        {
            string textData = richTextBoxFileWindow.Text;
            Find find = new Find(textData);
            find.Show();
        }

        private void textBoxOldSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewSymbol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
