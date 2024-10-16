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
    public partial class FrmFont : Form
    {
        public static FrmFont instance;
        public Form1 form1;
        private RichTextBox richTBoxFont;
        public FrmFont(RichTextBox richBox)
        {
            InitializeComponent();

            instance = this;
            form1 = new Form1();
            richTBoxFont = new RichTextBox();
            richTBoxFont = richBox;

            FontNames();
        }
        public FrmFont()
        {
                
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void hScrollBarFontSize_Scroll(object sender, ScrollEventArgs e)
        {
            if (hScrollBarFontSize.Value > 6)
            {
                // Define your logic to calculate the new font size based on scrollValue
                float newFontSize = hScrollBarFontSize.Value;

                // Apply the new font size (entire content or selected text)
                richTBoxFont.Font = new System.Drawing.Font(richTBoxFont.Font.FontFamily, newFontSize);
            }
        }
        private void FontNames()
        {
            FontFamily[] fontFamilies = FontFamily.Families;

            foreach (FontFamily fontFamily in fontFamilies)
            {
                comboBoxFontNames.Items.Add(fontFamily.Name);
            }
        }
        private void comboBoxFontNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontName = (string)comboBoxFontNames.SelectedItem;

            richTBoxFont.Font = new System.Drawing.Font(selectedFontName, richTBoxFont.SelectionFont.Size, richTBoxFont.SelectionFont.Style);
        }

        private void FrmFont_Load(object sender, EventArgs e)
        {

        }

        private void buttonDefault_Click(object sender, EventArgs e)
        {
            string selectedFontName = "Microsoft Sans Serif; 10pt";

            richTBoxFont.Font = new System.Drawing.Font(selectedFontName, richTBoxFont.SelectionFont.Size, richTBoxFont.SelectionFont.Style);
            
            comboBoxFontNames.Text = "Microsoft Sans Serif";
        }
    }
}
