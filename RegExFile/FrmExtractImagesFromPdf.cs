using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UglyToad.PdfPig.Content;

namespace RegExFile
{
    public partial class FrmExtractImagesFromPdf : Form
    {
        private static string destination = string.Empty;
        private List<string> lsPathWithFiles = new List<string>();
        private string[] pathWithFiles = { };
        private static string pathToAddFiles = string.Empty;
        public FrmExtractImagesFromPdf()
        {
            InitializeComponent();

            Thread thread = new Thread(PathToDesktop);
            thread.Start();
        }
        private void PathToDesktop()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            textBoxDestination.Text = path;
        }
        private void buttonOpenPdf_Click(object sender, EventArgs e)
        {
            //Open();
            GetPath();

            labelStatus.Text = $"{pathToAddFiles}";
        }

        //private void Open()
        //{
        //    FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

        //    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        destination = folderBrowserDialog1.SelectedPath;
        //    }
        //    else
        //    {
        //        destination = textBoxDestination.Text;
        //    }
        //}

        public void GetPath()
        {
            OpenFileDialog openFileDialog1 = OpenFile();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToAddFiles = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);

                pathWithFiles = openFileDialog1.FileNames;

                //lsPathWithFiles = pathWithFiles.ToList();
            }
            else
            {
                //pathWithFiles = new string[0];
                //lsPathWithFiles.Clear();
            }
            //return lsPathWithFiles;
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

        private void buttonExtract_Click(object sender, EventArgs e)
        {
            var document = UglyToad.PdfPig.PdfDocument.Open(pathWithFiles[0]);
            int count = 0;
            bool checkHaveNumberOfPages = false;

            foreach (var page in document.GetPages())
            {
                foreach (var pdfImage in page.GetImages())
                {
                    checkHaveNumberOfPages = true;
                    var bytes = TryGetImage(pdfImage);
                    var mem = new MemoryStream(bytes);
                    System.Drawing.Image img;
                    try
                    {
                        // Ensure data is valid 
                        img = System.Drawing.Image.FromStream(mem);
                        string destination = textBoxDestination.Text;
                        img.Save($"{destination}\\{count}.jpg");
                        count++;

                        // Free code : get the ideal file extension
                        var codec = ImageCodecInfo.GetImageDecoders().First(c => c.FormatID == img.RawFormat.Guid);
                        var extension = codec.FilenameExtension.Split(';').First().TrimStart('*', '.').ToLower();                      
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The file not contains images!!!");
                        return;
                    }
                }

                byte[] TryGetImage(IPdfImage image)
                {
                    if (image.TryGetPng(out var bytes))
                        return bytes;

                    if (image.TryGetBytes(out var iroBytes))
                        return iroBytes.ToArray();

                    return image.RawBytes.ToArray();
                }
            }
            if (checkHaveNumberOfPages == false)
            {
                MessageBox.Show("The file not contains images!!!");
            }
            else
            {
                MessageBox.Show("Done!");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDestination();
            textBoxDestination.Text = destination;
        }
        private void SaveDestination()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destination = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                destination = textBoxDestination.Text;
            }
        }

        private void buttonSameDir_Click(object sender, EventArgs e)
        {
            textBoxDestination.Text = pathToAddFiles;
        }
    }
}
