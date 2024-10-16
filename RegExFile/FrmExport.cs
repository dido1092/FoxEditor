using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
//using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iTextSharp.text.pdf.PdfDocument;
using System.IO;
using System.Drawing.Text;
using System.Web.UI.WebControls;
using SautinSoft.Document;

namespace RegExFile
{
    public partial class FrmExport : Form
    {
        public FrmExport instance;
        public static Form1 form1;
        private RichTextBox richTBox;
        private string[] pathWithFileExport;
        private HashSet<RememberText> hsRememberTextExport;
        private System.Windows.Forms.Label labelPathToExport = new System.Windows.Forms.Label();
        private System.Windows.Forms.CheckBox checkBoxInCurrentDocument;
        private List<string> lsContent = new List<string>();
        private string content = string.Empty;
        private string extensionFrmExport = string.Empty;
        private bool isComb3ButtonClicked = false;
        private List<DocPageContent> lsDocPageContent;
        public FrmExport(RichTextBox richBoxText,
            string[] pathWithFile,
            HashSet<RememberText> hsRememberText,
            System.Windows.Forms.Label labelExport,
            System.Windows.Forms.CheckBox checkBoxInCurrentDoc,
            List<string> lsCont,
            string extens, bool comb3button)
        {
            InitializeComponent();

            instance = this;
            form1 = new Form1();
            richTBox = richBoxText;
            pathWithFileExport = pathWithFile;
            hsRememberTextExport = hsRememberText;
            labelPathToExport = labelExport;
            checkBoxInCurrentDocument = checkBoxInCurrentDoc;
            lsContent = lsCont;
            extensionFrmExport = extens;
            isComb3ButtonClicked = comb3button;
        }
        public FrmExport(RichTextBox richBoxText,
            string[] pathWithFile,
            HashSet<RememberText> hsRememberText,
            System.Windows.Forms.Label labelExport,
            System.Windows.Forms.CheckBox checkBoxInCurrentDoc,
            string pageContent,
            string extens, bool comb3button, List<DocPageContent> lsDocPageContent)
        {
            InitializeComponent();

            instance = this;
            form1 = new Form1();
            richTBox = richBoxText;
            pathWithFileExport = pathWithFile;
            hsRememberTextExport = hsRememberText;
            labelPathToExport = labelExport;
            checkBoxInCurrentDocument = checkBoxInCurrentDoc;
            content = pageContent;
            extensionFrmExport = extens;
            isComb3ButtonClicked = comb3button;
            //this.lsDocPageContent = DocPageContent;
            this.lsDocPageContent = lsDocPageContent;
        }

        private void checkBoxSaveAllPages_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFromRememberPages.Checked = false;
        }

        private void checkBoxFromRememberPages_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSaveAllPages.Checked = false;
        }

        private void buttonExportTo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            string extension = $".{comboBoxExtenssions.Text.ToLower()}";

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!checkBoxInCurrentDocument.Checked)
                {
                    //if (checkBoxSaveAllPages.Checked && extensionFrmExport == ".pdf" || checkBoxSaveAllPages.Checked && extensionFrmExport == ".docx")
                    if (checkBoxSaveAllPages.Checked && extensionFrmExport == ".pdf")
                    {
                        PdfReader reader = new PdfReader(pathWithFileExport[0]);

                        form1.numPages = reader.NumberOfPages;

                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        progressBarExport.Minimum = 1;
                        progressBarExport.Maximum = form1.numPages;

                        for (int pageNum = 1; pageNum <= form1.numPages; pageNum++)
                        {
                            form1.createText = PdfTextExtractor.GetTextFromPage(reader, pageNum, strategy);
                            progressBarExport.Value = pageNum;
                        }
                        content = form1.createText;//form1.GetPdfPages(pathWithFileExport[0]);

                        int lenght = content.Length;
                    }
                    else if (checkBoxSaveAllPages.Checked && extensionFrmExport == ".docx")
                    {
                        //Aspose.Words.Document doc = new Aspose.Words.Document(pathWithFileExport[0]);

                        //////Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
                        //////NodeCollection bodyNodes = doc.GetChildNodes(NodeType.Body, true);
                        //////Aspose.Words.Body body = (Aspose.Words.Body)bodyNodes[0];
                        //Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
                        //builder.MoveToDocumentStart();
                        //foreach (var item in builder.Document)
                        //{
                        //    content += item.Document.GetText();
                        //    content += '\n';
                        //}
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in lsDocPageContent)
                        {
                            sb.Append(item.Content);
                        }
                        content = sb.ToString();
                        //content = form1.lsDocPagesContents.ToString();
                        //sbDocText.AppendLine(builder.Document.GetText());
                    }
                    else if (checkBoxSaveAllPages.Checked && extensionFrmExport == ".txt")
                    {
                        PageReadTxt reader = new PageReadTxt(pathWithFileExport[0]);

                        if (form1.lsGetToUpperContent.Count > 0)
                        {
                            foreach (var page in form1.lsGetToUpperContent)
                            {
                                form1.createText += page;
                            }
                        }
                        else if (form1.lsGetToLowerContent.Count > 0)
                        {
                            foreach (var page in form1.lsGetToLowerContent)
                            {
                                form1.createText += page;
                            }
                        }
                    }
                    else
                    {
                        form1.createText = richTBox.Text;
                    }
                    if (checkBoxFromRememberPages.Checked)
                    {
                        form1.createText = "";

                        foreach (var text in hsRememberTextExport.OrderBy(page => page.PageNum))
                        {
                            //if (text.PageNum % 2 == 0)
                            //{
                             //   form1.createText += Environment.NewLine + $" ===================================  {text.PageNum}  ===================================  " + Environment.NewLine + Environment.NewLine + $"{text.Text}" + Environment.NewLine;

                            //}
                            form1.createText += Environment.NewLine + $"{text.Text}" + Environment.NewLine;
                        }
                    }
                    //form1.extension = comboBoxExtenssions.Text.ToLower();
                    if (extension == "" || extension == " ")
                    {
                        MessageBox.Show("Select extension!");
                    }
                    else
                    {
                        if (checkBoxSaveAllPages.Checked)
                        {
                            if (extension == ".pdf" && form1.lsGetToUpperContent.Count > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_ToUpper.pdf";
                            }
                            else if (extension == ".pdf" && form1.lsGetToLowerContent.Count > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified__ToLower.pdf";
                            }
                            if (extension == ".txt" && form1.lsGetToUpperContent.Count > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_ToUpper.txt";
                            }
                            else if (extension == ".txt" && form1.lsGetToLowerContent.Count > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_ToLower.txt";
                            }
                            if (extension == ".docx" && form1.lsGetToUpperContent.Count > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_ToUpper.docx";
                            }
                            else if (extension == ".docx" && form1.lsGetToLowerContent.Count > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_ToLower.docx";
                            }
                            if (lsContent.Count() > 0 || content.Length > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_{extension}";
                            }
                            if (richTBox.Text.Length > 0)
                            {
                                form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(extensionFrmExport, ""))}_Modified_{extension}";
                            }
                        }
                        else
                        {
                            extensionFrmExport = folderBrowserDialog1.SelectedPath + $"\\{form1.page}{extensionFrmExport}";
                        }
                        if (checkBoxFromRememberPages.Checked)
                        {
                            if (isComb3ButtonClicked)
                            {
                                if (extensionFrmExport.Contains(".pdf"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".pdf", "") + $"_Modified_All_Pages.docx")}";//{extensionFrmExport}";
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".pdf", "") + $"_Modified_All_Pages.pdf")}";//{extensionFrmExport}";
                                    }
                                    else if (extension == ".txt")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".pdf", "") + $"_Modified_All_Pages.txt")}";//{extensionFrmExport}";
                                    }
                                }
                                else if (extensionFrmExport.Contains(".docx"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".docx", "") + $"_Modified_All_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".docx", "") + $"_Modified_All_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".docx", "") + $"_Modified_All_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                                else if (extensionFrmExport.Contains(".txt"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_All_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.Select(pn => pn.PageNum + 1))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        //form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{string.Join(" ", hsRememberTextExport.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}" + "_Pages")}{extensionFrmExport}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_All_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.Select(pn => pn.PageNum + 1))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        //form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{string.Join(" ", hsRememberTextExport.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}" + "_Pages")}{extensionFrmExport}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_All_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                                else if (extensionFrmExport.Contains(".jpg"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".jpg", "") + $"_Modified_All_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {                                      
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".jpg", "") + $"_Modified_All_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {                                        
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".jpg", "") + $"_Modified_All_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                                else if (extensionFrmExport.Contains(".png"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".png", "") + $"_Modified_All_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".png", "") + $"_Modified_All_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".png", "") + $"_Modified_All_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                            }
                            else
                            {
                                string pages = string.Empty;

                                if (hsRememberTextExport.Count > 40)
                                {
                                    pages = "MoreThen_40_pages";
                                }
                                else
                                {
                                    pages = string.Join(" ", hsRememberTextExport.OrderBy(x => x.PageNum).Select(pn => pn.PageNum));
                                }
                                if (extensionFrmExport.Contains(".pdf"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".pdf", "") + $"_Modified_" + $"{pages}" + "_Pages.docx")}";//{extensionFrmExport}";
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".pdf", "") + $"_Modified_" + $"{pages}" + "_Pages.pdf")}";//{extensionFrmExport}";
                                    }
                                    else if (extension == ".txt")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".pdf", "") + $"_Modified_" + $"{pages}" + "_Pages.txt")}";//{extensionFrmExport}";
                                    }
                                }
                                else if (extensionFrmExport.Contains(".docx"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".docx", "") + $"_Modified_" + $"{pages}" + "_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".docx", "") + $"_Modified_" + $"{pages}" + "_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".docx", "") + $"_Modified_" + $"{pages}" + "_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                                else if (extensionFrmExport.Contains(".txt"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{pages}" + "_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.Select(pn => pn.PageNum + 1))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        //form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{string.Join(" ", hsRememberTextExport.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}" + "_Pages")}{extensionFrmExport}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{pages}" + "_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {
                                        //destination = folderBrowserDialog1.SelectedPath + $"\\Modified_{string.Join(" ", hsRememberText.Select(pn => pn.PageNum + 1))}_Pages_{System.IO.Path.GetFileName(pathWithFile[pathWithFile.Length - 1].Replace(".pdf", ""))}.{extension}";//Take only name and extension
                                        //form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{string.Join(" ", hsRememberTextExport.OrderBy(x => x.PageNum).Select(pn => pn.PageNum))}" + "_Pages")}{extensionFrmExport}";//Take only name and extension
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".txt", "") + $"_Modified_" + $"{pages}" + "_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                                else if (extensionFrmExport.Contains(".jpg"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".jpg", "") + $"_Modified_" + $"{pages}" + "_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {                                                                             
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".jpg", "") + $"_Modified_" + $"{pages}" + "_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {                                                                               
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".jpg", "") + $"_Modified_" + $"{pages}" + "_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                                else if (extensionFrmExport.Contains(".png"))
                                {
                                    if (extension == ".docx")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".png", "") + $"_Modified_" + $"{pages}" + "_Pages.docx")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".pdf")
                                    {                                        
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".png", "") + $"_Modified_" + $"{pages}" + "_Pages.pdf")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                    else if (extension == ".txt")
                                    {
                                        form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1].Replace(".png", "") + $"_Modified_" + $"{pages}" + "_Pages.txt")}";//{extensionFrmExport}";//Take only name and extension
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    form1.destination = folderBrowserDialog1.SelectedPath + $"\\{System.IO.Path.GetFileName(pathWithFileExport[pathWithFileExport.Length - 1])}";
                }
                if (!File.Exists(form1.destination))
                {
                    DocumentCore dc = new DocumentCore();
                    ContentRange cr = dc.Content;

                    if (checkBoxSaveAllPages.Checked)
                    {
                        if (extensionFrmExport == ".txt")
                        {
                            cr.Start.Insert(string.Join("", lsContent));
                            cr.Start.Insert(content);
                        }
                        else if (extensionFrmExport == ".pdf" || extensionFrmExport == ".docx")
                        {
                            cr.Start.Insert(content);
                        }
                        else if (richTBox.Text.Length > 0)
                        {
                            cr.Start.Insert(form1.createText);
                        }
                    }
                    else
                    {
                        cr.Start.Insert(form1.createText);
                    }

                    dc.Save(form1.destination);


                    //==========================================================================================================================================================
                    //cr = dc.Content.Find("SautinSoft.Document 2024.4.24 trial. Get your free 30-day key instantly: https://sautinsoft.com/start-for-free/").FirstOrDefault();
                    //cr.Start.Insert("");
                    //destination = folderBrowserDialog1.SelectedPath + $"\\Without logo {page}.{extension}";
                    //dc.Save(destination);
                    //==========================================================================================================================================================
                    labelPathToExport.Text = $"PathToExport: {form1.destination}";

                    form1.Clear();

                    MessageBox.Show("Saved!");
                }
                else
                {
                    MessageBox.Show("File Exist! NOT SAVED!!!");
                }
            }
        }
    }
}
