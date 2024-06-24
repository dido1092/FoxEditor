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
    public partial class Find : Form
    {
        public string _text = string.Empty;

        public Find(string text)
        {
            InitializeComponent();
            //form1 = new Form1();
            this._text = text;
        }

        public void buttonReplaceInCurrentPage_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.richTextBoxFileWindow.Text = AccessRichTextBoxText();
            form1.Show();
        }
        private void buttonReplace_Click(object sender, EventArgs e)
        {

        }
        public string AccessRichTextBoxText()
        {
            string word = string.Empty;
            string newText = string.Empty;
            string oldSymbol = textBoxFind2.Text.Replace(" ", "");
            string newSymbol = textBoxReplace.Text.Replace(" ", "");

            if (oldSymbol.Length == 1 && newSymbol.Length == 1)
            {
                //string allText = text;

                string[] words = _text.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    word = words[i];

                    if (word.Contains(oldSymbol))
                    {
                        newText += word.Replace(oldSymbol, newSymbol);
                    }
                    else
                    {
                        newText += word + " ";
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter only 1 symbol on fields!");
            }
            return newText;
        }


    }
}
