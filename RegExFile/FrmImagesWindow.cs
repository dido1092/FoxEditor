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
    public partial class FrmImagesWindow : Form
    {
        public string getOcr = string.Empty;
        public string getLanguage = string.Empty;

        public FrmImagesWindow()
        {
            InitializeComponent();
        }

        private void buttonSelectOCR_Click(object sender, EventArgs e)
        {
            if (comboBoxImageReader.Text != "" && comboBoxLanguages.Text != "")
            {
                getOcr = comboBoxImageReader.Text;
                getLanguage = comboBoxLanguages.Text;

                this.Close();
            }
        }

        private void comboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
