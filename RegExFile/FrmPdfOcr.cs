using Aspose.Words.Pdf2Word.OCR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExFile
{
    public partial class FrmPdfOcr : Form
    {
        public string getPdfReader = string.Empty;
        public string getLanguage = string.Empty;

        public FrmPdfOcr()
        {
            InitializeComponent();
        }

        private void buttonSelectOCR_Click(object sender, EventArgs e)
        {
            //if (comboBoxPdfReader.Text == "IText Not OCR")
            //{
            //    getPdfReader = comboBoxPdfReader.Text;
            //}
            
            if (comboBoxPdfReader.Text != "" && comboBoxLanguages.Text != "")
            {
                getPdfReader = comboBoxPdfReader.Text;
                getLanguage = comboBoxLanguages.Text;

                this.Close();
            }
        }

        private void comboBoxPdfReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxPdfReader.SelectedItem == "Iron OCR")
            //{ 
            //    Form1 form1 = new Form1();
            //    DateTime dateTime = DateTime.Now;
            //    int currentDay = dateTime.Day;
            //    int currentMonth = dateTime.Month;
            //    int currentYear = dateTime.Year;

            //    string[] arrLicenseKey = form1.ironOcrLicenseKey.Split('.');
            //    int day = arrLicenseKey.Length - 3;
            //    int months = arrLicenseKey.Length - 2;
            //    int year = arrLicenseKey.Length - 1;

            //    //labelStatus.Text
            //}
        }
    }
}
