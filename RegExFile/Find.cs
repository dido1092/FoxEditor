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
        Form1 form1;
        //public static string textPassedFont;
        private static string text = string.Empty;

        public Find()
        {
            InitializeComponent();
            form1 = new Form1();
        }

        public void buttonReplaceInCurrentPage_Click(object sender, EventArgs e)
        {
            AccessRichTextBoxText();
        }
        public string AccessRichTextBoxText()
        {
            string word = string.Empty;
            string newText = string.Empty;
            string oldSymbol = textBoxFind2.Text.Replace(" ", "");
            string newSymbol = textBoxReplace.Text.Replace(" ", "");
            
            text = form1.GetRichTextBoxText();

            if (oldSymbol.Length == 1 && newSymbol.Length == 1)
            {
                //string allText = text;

                string[] words = text.Split(' ');

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
                //return newText;
            }
            else
            {
                MessageBox.Show("Enter only 1 symbol on fields!");
            }
            return newText;
        }
    }
}
