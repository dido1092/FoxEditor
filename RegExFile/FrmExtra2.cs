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
    public partial class FrmExtra2 : Form
    {
        private RichTextBox richTBox;

        public FrmExtra2(RichTextBox richTextBox)
        {
            richTBox = richTextBox;

            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (checkBoxInRow.Checked && richTBox.Text != "")
            {
                StringBuilder sbNewTextEven = new StringBuilder();
                StringBuilder sbNewTextOdd = new StringBuilder();

                string getText = richTBox.Text;

                string[] arrText = getText.Split('\n');

                for (int i = 0; i < arrText.Length; i ++)
                {
                    string currentRow = arrText[i];

                    if (i % 2 == 0)
                    {
                        sbNewTextEven.AppendLine(arrText[i]);
                    }
                    else
                    { 
                        sbNewTextOdd.AppendLine(arrText[i]);
                    }
                }

                richTBox.Text = string.Join("", sbNewTextEven);
                richTBox.Text += string.Join("", sbNewTextOdd);
            }
        }
    }
}
