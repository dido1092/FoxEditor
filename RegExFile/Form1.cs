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
//using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using static iTextSharp.text.pdf.PdfDocument;
using iTextSharp.text;
using System.Runtime.InteropServices.ComTypes;
using SixLabors.Fonts.Unicode;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;
using SautinSoft.Document;
using SautinSoft.Document.Drawing;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Drawing.Text;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using RichTextBox = System.Windows.Forms.RichTextBox;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Windows.Media;
using System.Drawing.Printing;
using SixLabors.ImageSharp.Processing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Windows.Input;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using SkiaSharp;
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using System.Windows.Media.TextFormatting;
using IronOcr;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Internal;
using Azure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DocumentFormat.OpenXml.Packaging;
using Aspose.Words;
using static IronOcr.OcrResult;
using Paragraph = Microsoft.Office.Interop.Word.Paragraph;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
//using EvoPdf.PdfImagesExtractor;
using DocumentFormat.OpenXml.Spreadsheet;
using License = IronOcr.License;
using DynamicTesseract;
using Org.BouncyCastle.Asn1.Pkcs;
using Tesseract;
using System.Reflection;
using System.Drawing.Imaging;
using UglyToad.PdfPig.Content;
using Aspose.Words.Pdf2Word.OCR;
using DocumentFormat.OpenXml.Bibliography;
using System.Security.Cryptography;
using Grpc.Core;


namespace RegExFile
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref System.Drawing.Point lpPoint);

        private const char Separator = ' ';
        private static string text = string.Empty;
        private static string name = string.Empty;
        private System.Windows.Forms.Timer autosaveTimer;
        private string _text;
        private Stack<string> undoList = new Stack<string>();
        private Stack<string> redoList = new Stack<string>();
        private string spellingWord = string.Empty;
        private string wrongWord = string.Empty;
        private int counterNextWord = 0;
        private int lastLinePosition = -1;
        //private string getWord = string.Empty;
        private bool isNextCheckWordClicked = false;
        private bool isPreviousCheckWordClicked = false;
        private int indexOfWords = 0;
        private List<IndexesCheckSpelling> lsIndexesCheckSpelling = new List<IndexesCheckSpelling>();
        private List<int> lsIndexOfWord = new List<int>();
        private int countLSGetIndexOfWord = 0;
        private int currentIndexFromText = 0;
        private int bufferWord = 0;
        private int countPrevious = 0;
        private List<string> lsPages = new List<string>();
        private string[] arrSplit = { " ", ".", ",", "!", "?", "'", "\'", "/", "„", "“", ":", "(", ")", ";", "«", "»", " ", "”", "\n", "\t" };
        private System.Windows.Forms.Cursor customCursor;
        private string[] arrDocText = { };
        private List<string> lsDocPages = new List<string>();
        private int bufferPage = 0;
        private int bufferNumPages = 0;

        public List<PdfPageContent> lsPdfPageContent = new List<PdfPageContent>();
        public List<DocPageContent> lsDocPagesContents = new List<DocPageContent>();
        public List<string> lsGetToUpperContent = new List<string>();
        public List<string> lsGetToLowerContent = new List<string>();
        public List<string> lsContent = new List<string>();
        public string destination = string.Empty;
        public string createText = string.Empty;
        public int lines = 0;
        public string getOCR = string.Empty;
        public string getLanguageFromImage = string.Empty;
        public string getPdfReader = string.Empty;
        public string getLanguageFromPdfReader = string.Empty;
        public int numPages = 0;
        public string[] pathWithFile = { };
        public string pathToAddFiles = string.Empty;
        public int page = 1;
        public HashSet<RememberText> hsRememberText = new HashSet<RememberText>();
        public string extension = string.Empty;
        public string pageContent = string.Empty;
        public string[] arrWordsInPage = { };
        public System.Windows.Forms.Label labelExport = new System.Windows.Forms.Label();
        public System.Windows.Forms.CheckBox checkInCurrentDocument = new System.Windows.Forms.CheckBox();
        public System.Windows.Forms.ComboBox comboBoxMinutesForm1 = new System.Windows.Forms.ComboBox();
        public bool checkBoxForm1Checked = false;
        public RichTextBox richTB;
        public Form1 instance;
        public FrmExtra1 frmExtra1 = new FrmExtra1();
        public static RegExFileContext context = new RegExFileContext();
        public bool isComb3ButtonsClicked = false;
        //public int currentPositionRichTextBox = 0;
        public int getCharIndexFromPosition = 0;
        public string ironOcrLicenseKey = string.Empty;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            labelExport = labelPathToExport;
            richTB = richTextBoxFileWindow;
            _text = "";
            autosaveTimer = new System.Windows.Forms.Timer();
            //frmLines = new FrmLines();
            //_newText = newText;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            this.Size = new System.Drawing.Size(Convert.ToInt32(0.5 * workingRectangle.Width), Convert.ToInt32(0.5 * workingRectangle.Height));

            this.Location = new System.Drawing.Point(10, 10);

            //customCursor = new System.Windows.Forms.Cursor(Properties.Resources);
        }

        private Stack<string> GetRedoList()
        {
            redoList.Push(richTextBoxFileWindow.Text);
            return redoList;
        }

        public void Clear()
        {
            textBoxPage.Text = "";
            textBoxRememberText.Text = "";
            hsRememberText.Clear();
            lsGetToLowerContent.Clear();
            lsGetToUpperContent.Clear();
            countPrevious = 0;
            lsIndexesCheckSpelling.Clear();
            destination = string.Empty;
            createText = string.Empty;
            isComb3ButtonsClicked = false;
            richTB.Clear();
        }

        public string[] GetPath()
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
        public string ReadPdf(string filePath)
        {
            return GetPdfPageText(filePath);
        }

        public string GetAllPdfText(string filePath)
        {
            string firstPage = string.Empty;

            //=============================== ITextSharp No OCR ===============================================
            if (this.getPdfReader == "IText Not OCR")
            {
                PdfReader reader = new PdfReader(filePath);

                numPages = reader.NumberOfPages;

                for (int i = 1; i <= numPages; i++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    pageContent = PdfTextExtractor.GetTextFromPage(reader, i, strategy);

                    if (i == 1)
                    {
                        firstPage = pageContent;
                    }

                    //======================= OPTIMIZATION =======================
                    PdfPageContent pdfPageContent = new PdfPageContent();
                    pdfPageContent.Page = i;
                    pdfPageContent.Content = pageContent;

                    lsPdfPageContent.Add(pdfPageContent);
                    //==========================================================

                    text += pageContent;
                }
                richTextBoxFileWindow.Text = ($"\n{text}");
                reader.Close();
            }
            //===================================================================================================

            //====================== Iron OCR For PDF ===========================================================
            else if (this.getPdfReader == "Iron OCR")
            {
                var ocr = new IronTesseract();

                if (getLanguageFromPdfReader == "Bul")
                {
                    ocr.Language = OcrLanguage.BulgarianBest;
                }
                else if (getLanguageFromPdfReader == "Eng")
                {
                    ocr.Language = OcrLanguage.EnglishBest;
                }
                else if (getLanguageFromPdfReader == "Lat")
                {
                    ocr.Language = OcrLanguage.LatinBest;
                }
                else if (getLanguageFromPdfReader == "LatAlhaBet")
                {
                    ocr.Language = OcrLanguage.LatinAlphabetBest;
                }
                License.LicenseKey = "IRONSUITE.DEYANGOSPODINOV1092.ABV.BG.11992-BF79B03DE9-B4EQ2UWZO2E5PU3X-EOJPBMWVYJUE-LRYF7Y4CZLYP-TP6YYVDIKEYM-W6LPJAHCQHQO-BMOPQVXRSLFX-2SBKRO-TJ5KH232522OUA-DEPLOYMENT.TRIAL-C7JVJN.TRIAL.EXPIRES.24.MAR.2025";
                ironOcrLicenseKey = License.LicenseKey;


                using (var ocrInput = new OcrInput())
                {
                    ocrInput.LoadPdf(filePath);

                    // Optionally Apply Filters if needed:
                    // ocrInput.Deskew();  // use only if image not straight
                    // ocrInput.DeNoise(); // use only if image contains digital noise

                    var ocrResult = ocr.Read(ocrInput);
                    richTextBoxFileWindow.Text = ($"\n{ocrResult.Text}");
                }
            }
            //===========================================================================================

            labelPages.Text = $"{page}/{numPages}";

            textBoxPage.Text = 1.ToString();
            page = 1;

            return text;
        }
        public string GetPdfPageText(string filePath)
        {
            if (page == 0)
            {
                page = 1;
            }
            //bool isFindedPage = false;

            //PdfReader reader = new PdfReader(filePath);

            //numPages = reader.NumberOfPages;

            //ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
            //pageContent = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
            foreach (var ppg in lsPdfPageContent)
            {
                //for (int i = 0; i < lsPdfPageContent.Count; i++)
                //{

                //richTextBoxFileWindow.Text = ($"\n{ppg}");
                //labelPages.Text = $"{page}/{numPages}";
                //text = pageContent;
                //int lenght = text.Length;
                if (ppg.Page == page)
                {
                    //richTextBoxFileWindow.Text = ($"\n{ppg.Content}");
                    richTextBoxFileWindow.Text = ($"{ppg.Content}");

                    //labelPages.Text = $"{page}/{lsPdfPageContent.Count()}";
                    text = ppg.Content;
                    //isFindedPage = true;

                    break;
                }
                //}

                //reader.Close();
            }
            labelPages.Text = $"{page}/{lsPdfPageContent.Count()}";
            return text;
        }

        public void ReadTxt(string filePath)
        {
            int pageSize = 40;
            var reader = new PageReadTxt(filePath);
            richTextBoxFileWindow.Text = "";


            lsContent = reader.GetPages();
            int count = 0;
            int numOfLines = lsContent.Count();
            numPages = numOfLines / pageSize;

            //if (frmExtra1.checkBoxForAllDoc() && lsGetToUpperContent.Count > 0)
            //{
            richTextBoxFileWindow.Text = "";
            //}

            DisplayPages(pageSize, lsContent, count);

            textBoxPage.Text = $"{page}";
            labelPages.Text = $"{page}/{numPages}";
        }
        public void ReadDocx(string filePath)
        {
            //if (page == 0)
            //{
            //    page = 1;
            //}
            richTextBoxFileWindow.Text = "";

            foreach (var docPage in lsDocPagesContents)
            {

                if (docPage.Page == page)
                {
                    richTextBoxFileWindow.Text = docPage.Content;

                    break;
                }
            }
            //StringBuilder sbDocText = new StringBuilder();
            //string docxText = string.Empty;

            //int countLines = 0;


            //if (page == 0)
            //{
            //    page = 1;
            //}
            //lines = 40 * page;
            //Aspose.Words.Document doc = new Aspose.Words.Document(filePath);

            //foreach (var page in doc.GetText().)
            //{
            //    richTextBoxFileWindow.Text += page;
            //}

            //=============================================================================

            //Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            //Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(filePath);

            //foreach (Paragraph objParagraph in doc.Paragraphs)
            //{
            //    //richTextBoxFileWindow.Text += objParagraph.Range.Text;
            //    sbDocText.AppendLine(objParagraph.Range.Text);
            //}
            //docxText = sbDocText.ToString();
            //arrDocText = docxText.Split('\r');
            //=============================================================================

            //lsDocPages.Clear();
            //for (int i = 0; i < arrDocText.Length; i++)
            //{
            //    lsDocPages.Add(arrDocText[i]);
            //}

            //var skippedLines = lsPages.Skip(lines);

            // Take the first 5 elements from the skipped numbers
            //var takenLines = lsPages.Take(40);


            //foreach (var item in lsPages)
            //{
            //    richTextBoxFileWindow.Text += item;
            //}

            //for (int i = lines; i < lsDocPages.Count; i++)
            //{
            //    countLines++;

            //    richTextBoxFileWindow.Text += lsDocPages[i];

            //    if (countLines == 80)
            //    {
            //        break;
            //    }
            //}
            //lines = 80 * page;

            textBoxPage.Text = page.ToString();
            labelPages.Text = $"{page}/{lsDocPagesContents.Count - 1}";
        }
        private void FillDocx()
        {
            richTextBoxFileWindow.Text = "";
            StringBuilder sbDocText = new StringBuilder();
            lsDocPagesContents = new List<DocPageContent>();
            StringBuilder sbContent = new StringBuilder();
            FrmLines frmLines = new FrmLines(lines);

            string docxText = string.Empty;
            //this.lines = frmLines.lines;
            int pages = 0;
            //lsDocPages.Clear();

            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document doc = app.Documents.Open(pathWithFile[0]);
            //doc.Close();
            //doc = app.Documents.Open(pathWithFile[0]);
            //Document doc = new Document(pathWithFile[0]);

            //Aspose.Words.Document doc = new Aspose.Words.Document(pathWithFile[0]);

            //Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
            //NodeCollection bodyNodes = doc.GetChildNodes(NodeType.Body, true);
            //Aspose.Words.Body body = (Aspose.Words.Body)bodyNodes[0];
            //Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
            //builder.MoveToDocumentStart();
            //sbDocText.AppendLine(builder.Document.GetText());

            //foreach (var item in builder.Document)
            //{
            //    sbDocText.Append(item.Document.GetText());
            //}



            foreach (Paragraph objParagraph in doc.Paragraphs)
            {
                //richTextBoxFileWindow.Text += objParagraph.Range.Text;
                sbDocText.AppendLine(objParagraph.Range.Text);
            }
            doc.Close();

            //docxText = sbDocText.ToString();
            //arrDocText = docxText.Split('\r');
            arrDocText = sbDocText.ToString().Split('\r');

            progressBarDoc.Value = 0;
            progressBarDoc.Minimum = 0;
            progressBarDoc.Maximum = arrDocText.Length;

            for (int i = 0; i < arrDocText.Length; i++)
            {
                //lines++;
                sbContent.Append(arrDocText[i]);//Append line by line
                //sbContent.Append("\r");//Append line by line

                //if (lines % 80 == 0)
                if (i % (lines * 2) == 0)
                {
                    DocPageContent docPageContent = new DocPageContent();
                    docPageContent.Page = pages;
                    docPageContent.Content = sbContent.ToString();

                    lsDocPagesContents.Add(docPageContent);

                    sbContent.Clear();

                    pages++;
                }
                progressBarDoc.Value++;
                //lsDocPages.Add(arrDocText[i]);
            }

            //------------------ Add Last Page -------------------
            DocPageContent docPageContent2 = new DocPageContent();
            docPageContent2.Page = pages;
            docPageContent2.Content = sbContent.ToString();

            lsDocPagesContents.Add(docPageContent2);
            //----------------------------------------------------

            numPages = lsDocPagesContents.Count;
        }
        public void ReadImage(string filePath)
        {
            //FrmImagesWindow frmImagesWindow = new FrmImagesWindow();

            if (this.getOCR == "Iron OCR")
            {
                //========================== IRON ===========================================================
                //License.LicenseKey = "IRONSUITE.DEYANGOSPODINOV1092.ABV.BG.11992-D51D934485-CZ35UVCKCH3LUV-B5LFNWDVUWYL-PFKJLCGQ2DNO-IDJY6HL6ZUCO-UCLYBAUCQTTI-DMP4QZXRSLFX-CKO25X-TYYDDSKMUI2NUA-DEPLOYMENT.TRIAL-W6RZK4.TRIAL.EXPIRES.11.OCT.2024";
                License.LicenseKey = "IRONSUITE.ORANGEBOX34.ABV.BG.17791-4E90C59BBD-BULQSL5-SF77KQ7R5HXG-GWBLGJF34DQQ-Q5OCVFRV7OOT-M6FJ7JSGHP46-7X6YV5EM5S47-XDOA7K7X6JF7-73Q5FD-TXUJ3T5HFC2OUA-DEPLOYMENT.TRIAL-VRXCEX.TRIAL.EXPIRES.04.FEB.2025";
                ironOcrLicenseKey = License.LicenseKey;

                var ocr = new IronTesseract();

                using (var input = new OcrInput())
                {
                    //// Load the image file
                    input.LoadImage(filePath);

                    var Ocr = new IronTesseract();

                    if (getLanguageFromImage == "Bul")
                    {
                        Ocr.Language = OcrLanguage.Bulgarian;
                    }
                    else if (getLanguageFromImage == "Eng")
                    {
                        Ocr.Language = OcrLanguage.English;
                    }
                    // Perform OCR on the image
                    OcrResult result = ocr.Read(input);

                    //// Access the extracted text
                    //string text = result.Text;

                    //// Print the extracted text to the console
                    richTextBoxFileWindow.Text = result.Text;
                }
                //========================================================================================================
            }
            else if (this.getOCR == "Tesseract OCR")
            {
                //========================== TESSERACT OCR Freeware ======================================================

                var path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                path = System.IO.Path.Combine(path, "tessdata");
                path = path.Replace("file:\\", "");

                if (getLanguageFromImage == "Bul")
                {
                    var engine = new TesseractEngine(path, "bul", Tesseract.EngineMode.TesseractAndLstm);

                    var image = Pix.LoadFromFile(filePath);
                    var pageTesseract = engine.Process(image);

                    richTextBoxFileWindow.Text = pageTesseract.GetText();
                }
                else if (getLanguageFromImage == "Eng")
                {
                    var engine = new TesseractEngine(path, "eng", Tesseract.EngineMode.TesseractAndLstm);

                    var image = Pix.LoadFromFile(filePath);
                    var pageTesseract = engine.Process(image);

                    richTextBoxFileWindow.Text = pageTesseract.GetText();
                }

                //========================================================================================================
            }
        }
        public string DisplayPages(int pageSize, List<string> lsContent, int count)
        {
            for (int line = page * pageSize; line < lsContent.Count(); line++)
            {
                if (count == pageSize)
                {
                    break;
                }

                if (frmExtra1.checkBoxForAllDoc() && lsGetToUpperContent.Count > 0)
                {
                    richTextBoxFileWindow.Text += $"{lsGetToUpperContent[line]}";
                }
                else if (frmExtra1.checkBoxForAllDoc() && lsGetToLowerContent.Count > 0)
                {
                    richTextBoxFileWindow.Text += $"{lsGetToLowerContent[line]}";
                }
                else
                {
                    richTextBoxFileWindow.Text += $"{lsContent[line]}";
                }

                count++;
            }
            return richTextBoxFileWindow.Text;
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

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void Previous()
        {
            richTextBoxSpelling.Text = "";

            if (page > 0)
            {
                page--;

                if (extension == ".pdf")
                {
                    ReadPdf(pathWithFile[0]);
                }
                else if (extension == ".txt")
                {
                    ReadTxt(pathWithFile[0]);
                }
                else if (extension == ".docx" || extension == ".doc")
                {
                    ReadDocx(pathWithFile[0]);
                }
            }
            else
            {
                page = 0;
            }
            if (extension == ".pdf")
            {
                textBoxPage.Text = $"{page}";
            }
            else if (extension == ".txt")
            {
                textBoxPage.Text = $"{page}";
            }

            arrWordsInPage = richTextBoxFileWindow.Text.Split('\n');

            labelDestination.Text = $"Destination: {string.Join("", pathWithFile)}";
            labelItems.Text = $"Items: {arrWordsInPage.Length}";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void Next()
        {
            richTextBoxSpelling.Text = "";

            if (extension == ".pdf")
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
            else if (extension == ".txt")
            {
                //if (page < (numPages / 40))// - 1)
                if (page < (numPages))// - 1)
                {
                    page++;
                    ReadTxt(pathWithFile[0]);
                }
                else
                {
                    //page = (numPages / 40); // - 1;
                    page = (numPages); // - 1;
                }
            }
            else if (extension == ".docx" || extension == ".doc")
            {
                if (page < lsDocPagesContents.Count - 1)// - 1)
                {
                    page++;
                    ReadDocx(pathWithFile[0]);
                }
                else
                {
                    page = (lsDocPagesContents.Count - 1); // - 1;
                }
            }
            //if (extension == ".pdf")
            //{
            //    textBoxPage.Text = $"{page}";
            //}
            //else if (extension == ".txt")
            //{
            //    textBoxPage.Text = $"{page}";
            //}
            //else if (extension == ".docx" || extension == ".doc")
            //{
            //    textBoxPage.Text = $"{page}";
            //}
            textBoxPage.Text = $"{page}";

            arrWordsInPage = richTextBoxFileWindow.Text.Split('\n');

            labelDestination.Text = $"Destination: {string.Join("", pathWithFile)}";
            labelItems.Text = $"Items: {arrWordsInPage.Length}";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
        }

        public void buttonSelectPege_Click(object sender, EventArgs e)
        {
            SelectPage();
        }

        public void SelectPage()
        {
            richTextBoxSpelling.Text = "";

            //bool isNumber = false;

            //isNumber = int.TryParse(textBoxPage.Text, out page);
            //if (true)
            //{

            //}
            //if (isNumber)
            //{
            page = int.Parse(textBoxPage.Text);

            if (extension == ".pdf")
            {
                //pathWithFile = GetPath();
                ReadPdf(pathWithFile[0]);
            }
            else if (extension == ".txt")
            {
                ReadTxt(pathWithFile[0]);
            }
            else if (extension == ".docx" || extension == ".doc")
            {
                ReadDocx(pathWithFile[0]);
            }
            arrWordsInPage = richTextBoxFileWindow.Text.Split('\n');

            labelDestination.Text = $"Destination: {string.Join("", pathWithFile)}";
            labelItems.Text = $"Items: {arrWordsInPage.Length}";
            //}
        }

        private System.Windows.Forms.RichTextBox GetRichTextBoxFileWindow()
        {
            return richTextBoxFileWindow;
        }

        public void richTextBoxFileWindow_TextChanged(object sender, EventArgs e)
        {
            undoList.Push(richTextBoxFileWindow.Text);
            redoList.Push(richTextBoxFileWindow.Text);
        }

        public void buttonRememberText_Click_1(object sender, EventArgs e)
        {
            HashSet<RememberText> hsGetText = RememberText();

            SaveToBufferFile(hsGetText);
        }

        private static void SaveToBufferFile(HashSet<RememberText> hsGetText)
        {
            StringBuilder sbAllText = new StringBuilder();

            string path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\REMEMBER_TEXT";

            bool exists = Directory.Exists(path);

            if (!exists)
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
            }

            foreach (var t in hsGetText)
            {
                sbAllText.AppendLine(t.Text);
            }

            File.WriteAllText(path + "\\Text_file.txt", string.Join("\n", sbAllText));
        }

        public HashSet<RememberText> RememberText()
        {
            if (!checkBoxSaveInCurrentDocument.Checked && checkBoxCut.Checked == false)
            {
                RememberText rememberText = new RememberText();

                rememberText.PageNum = page;

                rememberText.Text = richTextBoxFileWindow.Text;

                var previuosEqualPage = hsRememberText.Where(pn => pn.PageNum == page && pn.Text != richTextBoxFileWindow.Text).FirstOrDefault();

                if (previuosEqualPage != null)
                {
                    hsRememberText.Remove(previuosEqualPage);
                }

                //if (!textBoxRememberText.Text.Contains(page.ToString()))
                //if (!lsPages.Contains(page.ToString()))
                //{
                //    lsPages.Add(page.ToString());
                //}
                if (checkBoxAutoSaveForm1.Checked == false && hsRememberText.Select(p => p.PageNum.ToString()).Contains(page.ToString()))//textBoxRememberText.Text.Contains(page.ToString()))
                {
                    MessageBox.Show("The Page is Overwrode!");
                }

                hsRememberText.Add(rememberText).ToString().OrderBy(t => t);


            }
            else if (checkBoxCut.Checked)
            {
                RememberText rememberText = new RememberText();

                rememberText.PageNum = page;

                rememberText.Text = richTextBoxFileWindow.Text;

                var previuosEqualPage = hsRememberText.Where(pn => pn.PageNum == page && pn.Text != richTextBoxFileWindow.Text).FirstOrDefault();

                if (previuosEqualPage != null)
                {
                    hsRememberText.Remove(previuosEqualPage);
                }

                //if (!textBoxRememberText.Text.Contains(page.ToString()))
                //if (!lsPages.Contains(page.ToString()))
                //{
                //    lsPages.Add(page.ToString());
                //}
                if (checkBoxAutoSaveForm1.Checked == false && hsRememberText.Select(p => p.PageNum.ToString()).Contains(page.ToString()))//textBoxRememberText.Text.Contains(page.ToString()))
                {
                    MessageBox.Show("The Page is Overwrode!");
                }

                hsRememberText.Add(rememberText).ToString().OrderBy(t => t);
            }
            else
            {
                createText = richTextBoxFileWindow.Text;
                string destination = pathWithFile[0];

                //===========================================
                DocumentCore dc = new DocumentCore();
                ContentRange cr = dc.Content;

                cr.Start.Insert(createText);
                dc.Save(destination);
                //===========================================


                //cr = dc.Content.Find("SautinSoft.Document 2024.4.24 trial. Get your free 30-day key instantly: https://sautinsoft.com/start-for-free/").FirstOrDefault();
                //cr.Start.Insert("");
                //destination = folderBrowserDialog1.SelectedPath + $"\\Without logo {page}.{extension}";
                //dc.Save(destination);

                labelPathToExport.Text = $"PathToExport: {this.destination}";

                MessageBox.Show("Saved!");
            }

            //textBoxRememberText.Text = string.Join("\t", lsPages.OrderBy(p => p));
            textBoxRememberText.Text = string.Join("\t", hsRememberText.Select(p => p.PageNum).OrderBy(p => p));

            return hsRememberText;
        }

        private void buttonLoadRememberPage_Click(object sender, EventArgs e)
        {
            int remPage = 0;
            bool isNumber = Int32.TryParse(textBoxRememberText.SelectedText, out remPage);

            if (isNumber)
            {
                page = remPage;

                if (extension == ".pdf")
                {
                    ReadPdf(pathWithFile[0]);
                }
                else if (extension == ".txt")
                {
                    ReadTxt(pathWithFile[0]);
                }

                var remText = hsRememberText.Select(t => new { t.Text, t.PageNum }).Where(t => t.PageNum == remPage).FirstOrDefault();

                if (remText != null)
                {
                    richTextBoxFileWindow.Text = remText.Text;
                }
            }
        }
        private void buttonRemovePage_Click(object sender, EventArgs e)
        {
            int selectedPage = 0;
            bool isNumber = Int32.TryParse(textBoxRememberText.SelectedText, out selectedPage);

            if (isNumber)
            {
                selectedPage = int.Parse(textBoxRememberText.SelectedText);

                RememberText rm = new RememberText() { PageNum = selectedPage };

                hsRememberText.Remove(rm);
                lsPages.Remove(selectedPage.ToString());

                textBoxRememberText.Text = "";

                //textBoxRememberText.Text = string.Join("\t", lsPages.OrderBy(p => p));
                textBoxRememberText.Text = string.Join("\t", hsRememberText.Select(p => p.PageNum).OrderBy(p => p));
            }
        }

        private void textBoxOldSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxForAllDocument_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void labelItems_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            Open();
        }

        public void Open()
        {
            Clear();

            GetPath();

            if (pathWithFile.Count() > 0)
            {
                if (pathWithFile[0].Contains(".pdf"))
                {
                    page = 1;
                    extension = ".pdf";
                    ReadPdf(pathWithFile[0]);

                    //Only to fill "lsPdfPageContent"
                    lsPdfPageContent.Clear();

                    FrmPdfOcr frmPdfReader = new FrmPdfOcr();
                    frmPdfReader.ShowDialog();

                    this.getPdfReader = frmPdfReader.getPdfReader;
                    this.getLanguageFromPdfReader = frmPdfReader.getLanguage;

                    GetAllPdfText(pathWithFile[0]);
                }
                else if (pathWithFile[0].Contains(".txt"))
                {
                    page = 0;
                    extension = ".txt";
                    ReadTxt(pathWithFile[0]);
                }
                else if (pathWithFile[0].Contains(".docx") || pathWithFile[0].Contains(".doc"))
                {
                    page = 0;
                    extension = ".docx";

                    FrmLines frmLines = new FrmLines(lines);
                    frmLines.ShowDialog();

                    this.lines = frmLines.lines;

                    FillDocx();
                    ReadDocx(pathWithFile[0]);
                }
                else if (pathWithFile[0].Contains(".jpg") || pathWithFile[0].Contains(".png"))
                {
                    page = 0;
                    extension = ".jpg";

                    FrmImagesWindow frmImagesWindow = new FrmImagesWindow();
                    frmImagesWindow.ShowDialog();

                    this.getOCR = frmImagesWindow.getOcr;
                    this.getLanguageFromImage = frmImagesWindow.getLanguage;

                    ReadImage(pathWithFile[0]);


                }

                arrWordsInPage = richTextBoxFileWindow.Text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                progressBarDoc.Value = 0;

                labelDestination.Text = $"Destination: {string.Join("", pathWithFile)}";
                labelItems.Text = $"Lines: {arrWordsInPage.Length}";

                string[] arrLicenseKey = ironOcrLicenseKey.Split('.');

                //arrLicenseKey[arrLicenseKey.Length - 1] = 2023.ToString();
                //arrLicenseKey[arrLicenseKey.Length - 2] = "SEPT";
                //arrLicenseKey[arrLicenseKey.Length - 3] = 19.ToString();

                if (arrLicenseKey.Length > 1)
                {
                    string[] arrMonths = { "JAN", "FEB", "MAR", "APR", "MAY", "JUNE", "JULY", "AUG", "SEPT", "OCT", "NOV", "DEC" };
                    int indexOfMonth = 0;

                    DateTime dateTime = DateTime.Now;
                    int currentDay = dateTime.Day;
                    int currentMonth = dateTime.Month;
                    int currentYear = dateTime.Year;

                    labelLibraryStatus.Text = $"IronOCR Expired: {arrLicenseKey[arrLicenseKey.Length - 3]}.{arrLicenseKey[arrLicenseKey.Length - 2]}.{arrLicenseKey[arrLicenseKey.Length - 1]}";

                    if (int.Parse(arrLicenseKey[arrLicenseKey.Length - 1]) - currentYear < 0)
                    {
                        labelLibraryStatus.BackColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        string getMonth = arrLicenseKey[arrLicenseKey.Length - 2].ToString();

                        indexOfMonth = arrMonths.IndexOf(getMonth) + 1;

                        if (indexOfMonth - currentMonth < 0)
                        {
                            labelLibraryStatus.BackColor = System.Drawing.Color.Red;
                        }
                        else if (indexOfMonth - currentMonth == 0)
                        {
                            if (int.Parse(arrLicenseKey[arrLicenseKey.Length - 3]) - currentDay < 0)
                            {
                                labelLibraryStatus.BackColor = System.Drawing.Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            FrmFind find = new FrmFind(instance, richTextBoxFileWindow);
            find.TopMost = true;
            find.Show();
        }

        private void toolStripButtonExtra1_Click(object sender, EventArgs e)
        {
            FrmExtra1 frmExtra1 = new FrmExtra1(instance, richTextBoxFileWindow, pathWithFile, getCharIndexFromPosition);
            frmExtra1.TopMost = true;
            frmExtra1.Show();
        }

        private void toolStripButtonFont_Click(object sender, EventArgs e)
        {
            FrmFont frmFont = new FrmFont(richTextBoxFileWindow);
            frmFont.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void labelDestination_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)// Button Export
        {
            if (extension == ".txt")
            {
                FrmExport frmExport = new FrmExport(richTextBoxFileWindow, pathWithFile, hsRememberText, labelExport, checkInCurrentDocument, lsContent, extension, isComb3ButtonsClicked);
                frmExport.Show();

            }
            else if (extension == ".pdf")
            {
                FrmExport frmExport = new FrmExport(richTextBoxFileWindow, pathWithFile, hsRememberText, labelExport, checkInCurrentDocument, pageContent, extension, isComb3ButtonsClicked, lsDocPagesContents);
                frmExport.Show();
            }
            else if (extension == ".docx")
            {
                FrmExport frmExport = new FrmExport(richTextBoxFileWindow, pathWithFile, hsRememberText, labelExport, checkInCurrentDocument, pageContent, extension, isComb3ButtonsClicked, lsDocPagesContents);
                frmExport.Show();
            }
            else if (extension == ".jpg" || extension == ".png")
            {
                FrmExport frmExport = new FrmExport(richTextBoxFileWindow, pathWithFile, hsRememberText, labelExport, checkInCurrentDocument, pageContent, extension, isComb3ButtonsClicked, lsDocPagesContents);
                frmExport.Show();
            }
            else
            {
                MessageBox.Show("Open a File!");
            }
        }

        private void labelPathToExport_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSaveInCurrentDocument_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxSaveInCurrentDocument.Checked && extension == ".txt")
            {
                var reader = new PageReadTxt(pathWithFile[0]);
                richTextBoxFileWindow.Text = "";

                lsContent = reader.GetPages();

                foreach (var getPage in lsContent)
                {
                    richTextBoxFileWindow.Text += getPage;
                }
                page = 0;
                numPages = 0;
                textBoxPage.Text = $"{page}";
                labelPages.Text = $"{page}/{numPages}";
                labelItems.Text = $"Lines: {arrWordsInPage.Length}";
            }
            else
            {
                MessageBox.Show("Only for .txt files");
                checkBoxSaveInCurrentDocument.Checked = false;
            }
        }

        public void comboBoxMin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            System.Windows.Forms.PrintDialog pd = new System.Windows.Forms.PrintDialog();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = doc;
            pd.Document = doc;
            doc.PrintPage += new PrintPageEventHandler(doc_PrintPage);

            if (ppd.ShowDialog() == DialogResult.OK)
            {
                if (pd.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
        }
        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = 10;
            int y = 0;
            int charpos = 0;
            while (charpos < richTextBoxFileWindow.Text.Length)
            {
                if (richTextBoxFileWindow.Text[charpos] == '\n')
                {
                    charpos++;
                    y += 20;
                    x = 10;
                }
                else if (richTextBoxFileWindow.Text[charpos] == '\r')
                {
                    charpos++;
                }
                else
                {
                    richTextBoxFileWindow.Select(charpos, 1);
                    e.Graphics.DrawString(richTextBoxFileWindow.SelectedText, richTextBoxFileWindow.SelectionFont,
                        new SolidBrush(richTextBoxFileWindow.SelectionColor), new PointF(x, y));
                    x = x + 8;
                    charpos++;
                }
            }
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            richTextBoxFileWindow.Undo();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            richTextBoxFileWindow.Redo();
        }
        public bool IsChecked
        {
            get { return checkBoxAutoSaveForm1.Checked; }
            set { checkBoxAutoSaveForm1.Checked = value; }
        }
        private void checkBoxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBoxFileWindow.Text == "")
            {
                checkBoxAutoSaveForm1.Checked = false;
                MessageBox.Show("Open File!");
                return;
            }
            if (checkBoxAutoSaveForm1.Checked)
            {
                if (comboBoxAutoSaveForm1.Text != "")
                {
                    autosaveTimer = new System.Windows.Forms.Timer();
                    autosaveTimer.Interval = int.Parse(comboBoxAutoSaveForm1.Text) * 1000; // 60000 = 1 minute interval
                    autosaveTimer.Tick += buttonRememberText_Click_1;
                    autosaveTimer.Start();

                    labelAutoSave.Text = $"Auto Save on {comboBoxAutoSaveForm1.Text}sec.";
                    labelAutoSave.ForeColor = System.Drawing.Color.MediumSeaGreen;

                    //checkBoxAutoSaveForm1.Checked = IsChecked = true;
                    checkBoxAutoSaveForm1.Checked = true;
                }
                else
                {
                    //checkBoxFrmAutoSave.Checked = IsChecked = false;
                    checkBoxAutoSaveForm1.Checked = false;

                    MessageBox.Show("Enter seconds!");
                    return;
                }
            }
            else
            {
                //autosaveTimer.Enabled = false;
                //checkBoxFrmAutoSave.Checked = IsChecked = false;

                autosaveTimer.Stop();
                comboBoxAutoSaveForm1.Text = "";
                labelAutoSave.Text = $"Auto Save";
                labelAutoSave.ForeColor = System.Drawing.Color.Empty;

                checkBoxAutoSaveForm1.Checked = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmDatabase frmDatabase = new FrmDatabase();
            frmDatabase.Show();
        }
        private void button_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // Handle space key press (e.g., simulate a button click)
                //button_Click(sender, e); // Simulate click if desired
                CheckSpelling();
            }
        }

        private void checkBoxCheckSpelling_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCheckSpelling.Checked)
            {
                currentIndexFromText = 0;
                indexOfWords = 0;
                countPrevious = 0;
                lsIndexesCheckSpelling.Clear();

                CheckSpelling();
            }
        }

        private void CheckSpelling()
        {
            richTextBoxSpelling.Text = "";

            richTextBoxFileWindow.SelectAll();
            richTextBoxFileWindow.SelectionColor = System.Drawing.Color.Black;
            //=================================================================
            StringBuilder sbSpellingWords = new StringBuilder();

            string patternBg = @"([а-яА-Я]+)";
            string patternEn = @"([a-zA-Z]+)";

            var bgWordsDb = context.BgWords.Select(w => w.BgWord).ToHashSet();
            var enWordsDb = context.EnWords.Select(w => w.EnWord).ToHashSet();

            string text = richTextBoxFileWindow.Text;

            string currentWord = string.Empty;
            string getLetter = string.Empty;
            string getWord = string.Empty;
            char currentSymbol = ' ';

            //currentIndexFromText = 0;
            //indexOfWords = 0;
            //countPrevious = 0;
            //lsIndexesCheckSpelling.Clear();


            //string[] arrSplit = { " ", "(", ")", "«", "»", " ", "\n" };

            string[] words = text.Split(arrSplit, StringSplitOptions.None);
            words = text.Split(arrSplit, StringSplitOptions.RemoveEmptyEntries);

            if (isPreviousCheckWordClicked && lsIndexesCheckSpelling.Count > 0)
            {
                countPrevious++;

                var getIndexes = lsIndexesCheckSpelling.Select(i => new { i.IndexCurrentWord, i.IndexFromText, i.CountIndexes }).Where(i => i.CountIndexes == lsIndexesCheckSpelling.Count() - countPrevious);//countLSGetIndexOfWord);

                if (getIndexes.Count() > 0)
                {
                    foreach (var index in getIndexes)
                    {
                        indexOfWords = index.IndexCurrentWord;
                        currentIndexFromText = index.IndexFromText;
                    }
                }
                else
                {
                    indexOfWords = 0;
                    currentIndexFromText = 0;
                }

                if (countPrevious == lsIndexesCheckSpelling.Count)
                {
                    countPrevious = 0;
                    lsIndexesCheckSpelling.Clear();
                }

                isPreviousCheckWordClicked = false;
            }

            for (int currentIndexFromWord = indexOfWords; currentIndexFromWord < words.Length; currentIndexFromWord++)
            {
                getWord = words[currentIndexFromWord].ToUpper();

                if (getWord.Contains("-") || getWord.Contains("\u00AD"))
                {
                    getWord = getWord.Replace("-", "");
                    getWord += words[currentIndexFromWord + 1].ToUpper();

                    currentIndexFromWord++;
                    continue;
                }
                currentWord = getWord;

                if (currentWord != "")
                {
                    for (int j = currentIndexFromText; j < text.Length; j++)
                    {
                        getLetter += text[j].ToString().ToUpper();

                        currentSymbol = text[j];

                        int getLetterLength = getLetter.Length;

                        currentIndexFromText++;

                        if (getLetter.Length > 1)
                        {
                            if (getLetter.Contains(currentWord))
                            {
                                getLetter = "";
                                break;
                            }
                        }
                    }

                    int indexFromText = currentIndexFromText - currentWord.Length;

                    currentWord = currentWord.Replace(" ", "");

                    int wordLength = currentWord.Length;

                    if (Regex.Matches(currentWord, patternBg).Count > 0 && currentWord.Length > 1)
                    {
                        if (!bgWordsDb.Contains(currentWord))
                        {
                            wrongWord = words[currentIndexFromWord];
                            //wrongWord = currentWord;

                            richTextBoxFileWindow.Select(indexFromText, currentWord.Length);

                            richTextBoxFileWindow.SelectionColor = System.Drawing.Color.Red;

                            var bgWordsWithSameLengthFromDb = context.BgWords.Select(w => new { w.BgWord, w.Length }).Where(w => w.Length == currentWord.Length).ToHashSet();

                            foreach (var bgWordFromDb in bgWordsWithSameLengthFromDb)
                            {
                                string getWordFromDb = bgWordFromDb.BgWord;

                                int tollerance = int.Parse(comboBoxTollerance.Text);

                                bool isSimilarity = IsSimilarity(getWordFromDb, currentWord, tollerance);

                                if (isSimilarity)
                                {
                                    string correctWord = string.Empty;

                                    for (int k = 0; k < getWordFromDb.Length; k++)
                                    {
                                        bool isUpper = char.IsUpper(wrongWord[k]);

                                        if (isUpper)
                                        {
                                            correctWord += getWordFromDb[k].ToString().ToUpper();
                                        }
                                        else
                                        {
                                            correctWord += getWordFromDb[k].ToString().ToLower();
                                        }
                                    }
                                    sbSpellingWords.Append(correctWord + "\n");
                                }
                            }

                            richTextBoxSpelling.Text = string.Join("", sbSpellingWords.ToString() + Environment.NewLine);

                            IndexesCheckSpelling indexesCheckSpelling = new IndexesCheckSpelling();

                            indexesCheckSpelling.IndexCurrentWord = currentIndexFromWord;
                            indexesCheckSpelling.IndexFromText = indexFromText;
                            indexesCheckSpelling.CountIndexes = lsIndexesCheckSpelling.Count + 1;

                            var getFromLSIndexCurrentWord = lsIndexesCheckSpelling.Select(i => new { i.IndexCurrentWord }).Where(x => x.IndexCurrentWord == currentIndexFromWord).FirstOrDefault();

                            if (lsIndexesCheckSpelling.Count == 0)
                            {
                                if (getFromLSIndexCurrentWord == null)
                                {
                                    lsIndexesCheckSpelling.Add(indexesCheckSpelling);
                                }
                            }
                            else
                            {
                                if (getFromLSIndexCurrentWord == null)
                                {
                                    lsIndexesCheckSpelling.Add(indexesCheckSpelling);
                                }
                            }
                            if (isNextCheckWordClicked)
                            {
                                indexOfWords = currentIndexFromWord;

                                isNextCheckWordClicked = false;
                                isPreviousCheckWordClicked = false;

                                if (countPrevious > 0)
                                {
                                    countPrevious--;
                                }
                            }
                            else
                            {
                                indexOfWords = currentIndexFromWord;
                            }

                            break;
                        }
                    }
                    else if (Regex.Matches(currentWord, patternEn).Count > 0 && currentWord.Length > 1)
                    {
                        if (!enWordsDb.Contains(currentWord))
                        {
                            wrongWord = words[currentIndexFromWord];
                            //wrongWord = currentWord;

                            richTextBoxFileWindow.Select(indexFromText, wrongWord.Length);
                            richTextBoxFileWindow.SelectionColor = System.Drawing.Color.Red;

                            var enWordWithSameLength = context.EnWords.Select(w => new { w.EnWord, w.Length }).Where(w => w.Length == currentWord.Length).ToHashSet();

                            foreach (var enWordFromDb in enWordWithSameLength)
                            {
                                string getWordFromDb = enWordFromDb.EnWord;

                                int tollerance = int.Parse(comboBoxTollerance.Text);

                                bool isSimilarity = IsSimilarity(getWordFromDb, currentWord, tollerance);

                                if (isSimilarity)
                                {
                                    string correctWord = string.Empty;

                                    for (int k = 0; k < currentWord.Length; k++)
                                    {
                                        bool isUpper = char.IsUpper(wrongWord[k]);

                                        if (isUpper)
                                        {
                                            correctWord += getWordFromDb[k].ToString().ToUpper();
                                        }
                                        else
                                        {
                                            correctWord += getWordFromDb[k].ToString().ToLower();
                                        }
                                    }
                                    sbSpellingWords.Append(correctWord + "\n");
                                }
                            }

                            richTextBoxSpelling.Text = string.Join("", sbSpellingWords.ToString() + Environment.NewLine);

                            IndexesCheckSpelling indexesCheckSpelling = new IndexesCheckSpelling();

                            indexesCheckSpelling.IndexCurrentWord = currentIndexFromWord;
                            indexesCheckSpelling.IndexFromText = indexFromText;
                            indexesCheckSpelling.CountIndexes = lsIndexesCheckSpelling.Count + 1;

                            var getFromLSIndexCurrentWord = lsIndexesCheckSpelling.Select(i => new { i.IndexCurrentWord }).Where(x => x.IndexCurrentWord == currentIndexFromWord).FirstOrDefault();

                            if (lsIndexesCheckSpelling.Count == 0)
                            {
                                if (getFromLSIndexCurrentWord == null)
                                {
                                    lsIndexesCheckSpelling.Add(indexesCheckSpelling);
                                }
                            }
                            else
                            {
                                if (getFromLSIndexCurrentWord == null)
                                {
                                    lsIndexesCheckSpelling.Add(indexesCheckSpelling);
                                }
                            }

                            if (isNextCheckWordClicked)
                            {
                                indexOfWords = currentIndexFromWord;
                                isNextCheckWordClicked = false;

                                if (countPrevious > 0)
                                {
                                    countPrevious--;
                                }
                            }
                            else
                            {
                                indexOfWords = currentIndexFromWord;
                            }

                            break;
                        }
                    }
                }
            }
        }

        public static bool IsSimilarity(string wordCorrect, string wordFromText, int tollerance)
        {
            if (wordCorrect == null || wordFromText == null)
            {
                throw new ArgumentNullException();
            }
            string word = string.Empty;
            bool isMatch = false;

            for (int i = 0; i < wordCorrect.Length; i++)
            {
                if (wordCorrect[i] == wordFromText[i])
                {
                    word += wordCorrect[i];
                }
            }

            if (wordCorrect.Length - tollerance == word.Length)
            {
                isMatch = true;
            }

            return isMatch;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            spellingWord = richTextBoxSpelling.SelectedText.Replace(" ", "");

            if (spellingWord.Count() > 0)
            {
                if (wrongWord.Length == spellingWord.Length)
                {
                    richTextBoxFileWindow.Text = ReplaceSpellingWord(spellingWord);
                    richTextBoxFileWindow.TextChanged += richTextBoxFileWindow_TextChanged;
                    labelSpellingInfo.Text = $"Change \"{wrongWord}\" To \"{spellingWord}\"";
                }
            }
        }
        private string ReplaceSpellingWord(string spellingWord)
        {
            string newText = string.Empty;
            //string word = string.Empty;
            //string[] arrCurrentSplit = { " ", "\n" };
            //int bufferJ = 0;
            //string getText = richTextBoxFileWindow.Text;
            //string[] arrGetText = richTextBoxFileWindow.Text.Split(arrSplit, StringSplitOptions.None);
            //bool isEncountedWord = false;

            newText = richTextBoxFileWindow.Text.Replace(wrongWord, spellingWord);

            //return newText;
            //}

            //for (int j = bufferJ; j < richTextBoxFileWindow.Text.Length; j++)
            //{
            //    newText += getText[j];
            //    string[] getWord = newText.Split(arrCurrentSplit, StringSplitOptions.RemoveEmptyEntries);
            //    int getWordLength = getWord.Length;

            //    if (getWord[getWordLength - 1] == '\n'.ToString())
            //    {
            //        word = getWord[getWordLength - 1];
            //    }
            //    if (word == wrongWord)
            //    {
            //        newText = newText.Remove(j - wrongWord.Length + 1, wrongWord.Length);
            //        newText += spellingWord;

            //        bufferJ = j + 1;
            //    }
            //}
            return newText;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonInsertWordIntoDB_Click(object sender, EventArgs e)
        {
            string wordCyrillic = string.Empty;
            string wordNotCyrillic = string.Empty;
            string wrongWord = string.Empty;

            List<char> lsLetters = new List<char>();
            int countCyrillicLetters = 0;
            int countNotCyrillicLetters = 0;

            string selectedWord = richTextBoxFileWindow.SelectedText.ToUpper().Replace(" ", "");

            if (selectedWord.Length > 0)
            {
                var bgWords = context.BgWords.Where(w => w.BgWord == selectedWord).FirstOrDefault();
                var enWords = context.EnWords.Where(w => w.EnWord == selectedWord).FirstOrDefault();

                for (int i = 0; i < selectedWord.Length; i++)
                {
                    int letter = selectedWord[i];

                    if (letter >= 1040 && letter <= 1103)
                    {
                        wordCyrillic += selectedWord[i];
                        //isCyrillic = true;
                        countCyrillicLetters++;
                    }
                    else if (letter >= 65 && letter <= 90 || letter >= 97 && letter <= 122)
                    {
                        wordNotCyrillic += selectedWord[i];
                        //isCyrillic = false;
                        countNotCyrillicLetters++;
                    }
                    wrongWord += selectedWord[i];

                }
                if (wordNotCyrillic.Length > wordCyrillic.Length && wordCyrillic.Length > 0)
                {
                    MessageBox.Show($"Wrong word!\nThe wrong letters is: '{string.Join(", ", wordCyrillic)}'");
                }
                else if (wordCyrillic.Length >= wordNotCyrillic.Length && wordNotCyrillic.Length > 0)
                {
                    MessageBox.Show($"Wrong word!\nThe wrong letters is: '{string.Join(", ", wordNotCyrillic)}'");
                }
                // =====================================  INSERT INTO TABLES =================================

                if (countCyrillicLetters == selectedWord.Length && bgWords == null && wordCyrillic.Length == selectedWord.Length)
                {
                    BgWords wBg = new BgWords()
                    {
                        BgWord = selectedWord,
                        Length = selectedWord.Length,
                        DateTime = DateTime.Now
                    };
                    context.BgWords.Add(wBg);

                    context.SaveChanges();

                    MessageBox.Show("Import in BgTable Done!");
                }
                else if (countNotCyrillicLetters == selectedWord.Length && enWords == null && wordNotCyrillic.Length == selectedWord.Length)
                {
                    EnWords wEn = new EnWords()
                    {
                        EnWord = selectedWord,
                        Length = selectedWord.Length,
                        DateTime = DateTime.Now
                    };
                    context.EnWords.Add(wEn);

                    context.SaveChanges();

                    MessageBox.Show("Import in EnTable Done!");
                }
            }
        }

        private void buttonConvertToBgCyrillic_Click(object sender, EventArgs e)
        {
            ConvertToCyrillic(richTextBoxFileWindow.Text);
        }

        public StringBuilder ConvertToCyrillic(string text)
        {
            StringBuilder newText = new StringBuilder();

            char[] arrSpecialSymbols = { 'À', 'à', 'Á', 'á', 'Â', 'â','Ã', 'ã', 'Ä', 'ä', 'Å', 'å', 'Æ', 'æ', 'Ç', 'ç', 'È', 'è', 'É', 'é', 'Ê', 'ê', 'Ë', 'ë', 'Ì', 'ì', 'Í' , 'í', 'Î', 'î',
            'Ï', 'ï', 'Ð', 'ð', 'Ñ', 'ñ', 'Ò', 'ò', 'Ó', 'ó', 'Ô', 'ô', 'Õ', 'õ', 'Ö', 'ö', '×', '÷', 'Ø', 'ø', 'Ù', 'ù', 'Ú', 'ú', 'ü', 'Þ', 'þ', 'ß', 'ÿ'};


            char[] arrCyrillSymbols = { 'А', 'а', 'Б', 'б', 'В', 'в', 'Г','г', 'Д', 'д', 'Е', 'е', 'Ж', 'ж', 'З', 'з', 'И', 'и', 'Й', 'й', 'К', 'к', 'Л', 'л', 'М', 'м', 'Н' , 'н', 'О', 'о',
            'П', 'п', 'Р', 'р', 'С', 'с', 'Т', 'т', 'У', 'у', 'Ф', 'ф', 'Х', 'х', 'Ц', 'ц', 'Ч', 'ч', 'Ш', 'ш', 'Щ', 'щ', 'Ъ', 'ъ', 'ь', 'Ю', 'ю', 'Я', 'я'};


            //text = richTextBoxFileWindow.Text;

            //string[] arrLines = text.Split('\n');

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (arrSpecialSymbols.Contains(letter))
                {
                    int index = arrSpecialSymbols.IndexOf(letter);

                    newText.Append(arrCyrillSymbols[index]);
                }
                else
                {
                    newText.Append(letter);
                }

            }
            richTextBoxFileWindow.Text = string.Join("", newText);

            return newText;
        }

        private void buttonComb3Buttons_Click(object sender, EventArgs e)
        {
            if (checkBoxCut.Checked)
            {
                int numberFromPage = int.Parse(textBoxFromPage.Text);
                int numberToPage = int.Parse(textBoxToPage.Text);

                if (numberToPage > numberFromPage)
                {
                    page = numberFromPage - 1;
                    //numPages = numberToPage - 1;

                    Next();
                    ConvertToCyrillic(richTextBoxFileWindow.Text);
                    RememberText();

                    for (int i = numberFromPage; i < numberToPage; i++)
                    {
                        Next();
                        ConvertToCyrillic(richTextBoxFileWindow.Text);
                        RememberText();
                    }
                    isComb3ButtonsClicked = true;
                }
            }
            else
            {
                page = 0;
                //numPages = 1;

                ConvertToCyrillic(richTextBoxFileWindow.Text);
                RememberText();

                for (int i = page + 1; i <= numPages; i++)
                {
                    Next();
                    ConvertToCyrillic(richTextBoxFileWindow.Text);
                    RememberText();
                }
                isComb3ButtonsClicked = true;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (pathWithFile.Length > 0)
            {
                FrmPdf_FindPages frmPdf = new FrmPdf_FindPages(richTextBoxFileWindow, textBoxPage, page, pathWithFile[0]);
                frmPdf.Show();
            }
            else
            {
                MessageBox.Show("Open a file!");
            }
        }

        //private void buttonGetLocation_Click(object sender, EventArgs e)
        //{
        //    //System.Drawing.Point pt = new System.Drawing.Point();

        //    //pt.X = richTextBoxFileWindow.Location.X;
        //    //pt.Y = richTextBoxFileWindow.Location.Y;

        //    //labelItems.Text = $"X: {pt.X} Y: {pt.Y}";
        //}

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            richTextBoxSpelling.Text = "";

            richTextBoxFileWindow.SelectAll();
            richTextBoxFileWindow.SelectionColor = System.Drawing.Color.Black;

            indexOfWords++;

            isNextCheckWordClicked = true;
            isPreviousCheckWordClicked = false;

            //checkBoxCheckSpelling.Checked = false;

            CheckSpelling();
        }

        private void buttonPreviousCheckWord_Click(object sender, EventArgs e)
        {
            richTextBoxSpelling.Text = "";

            richTextBoxFileWindow.SelectAll();
            richTextBoxFileWindow.SelectionColor = System.Drawing.Color.Black;

            isNextCheckWordClicked = false;
            isPreviousCheckWordClicked = true;

            //checkBoxCheckSpelling.Checked = false;

            CheckSpelling();
        }

        private void toolStripButtonConvertLetters_Click(object sender, EventArgs e)
        {
            FrmConvertLetters frmConvertLetters = new FrmConvertLetters(richTextBoxFileWindow);
            frmConvertLetters.TopMost = true;
            frmConvertLetters.Show();
        }

        private void lineNumbers_For_RichTextBox1_Click(object sender, EventArgs e)
        {

        }

        public void textBoxPage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRememberText.Text = "";
            hsRememberText.Clear();
        }

        private void checkBoxCut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButtonExtractImages_Click(object sender, EventArgs e)
        {
            FrmExtractImagesFromPdf frmExtractImagesFromPdf = new FrmExtractImagesFromPdf();
            frmExtractImagesFromPdf.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmExtra2 frmExtra2 = new FrmExtra2(richTextBoxFileWindow);

            frmExtra2.Show();
        }

        private void toolStripButtonMerge_Click(object sender, EventArgs e)
        {
            FrmMergeTxt frmMergeTxt = new FrmMergeTxt();
            frmMergeTxt.Show();
        }

        private void toolStripButtonExtractIntoFile_Click(object sender, EventArgs e)
        {
            FrmExtractFile frmExtractFile = new FrmExtractFile();  
            frmExtractFile.Show();
        }
    }
}
