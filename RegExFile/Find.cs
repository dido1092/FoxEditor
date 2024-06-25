using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExFile
{
    public partial class Find : Form
    {
        public static Find instance;
        public static Form1 form1;
        public string _text = string.Empty;
        private string name = string.Empty;
        private int index = 0;

        public Find(Form1 f, string text)
        {
            InitializeComponent();
            this._text = text;
            instance = this;
            form1 = f;
        }
        private void Find_Load(object sender, EventArgs e)
        {
            instance.TopMost = true;
        }
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            this._text = form1.richTextBoxFileWindow.Text;
            ReplaceNextWord(_text);
            form1.richTextBoxFileWindow.Text = ReplaceNextWord(_text);
        }
        public void buttonReplaceInCurrentPage_Click(object sender, EventArgs e)
        {
            this._text = form1.richTextBoxFileWindow.Text;
            ReplaceInCurrentPage(_text);
            form1.richTextBoxFileWindow.Text = ReplaceInCurrentPage(_text);
        }


        private string ReplaceNextWord(string _text)
        {
            string oldSymbol = textBoxFind2.Text.Replace(" ", "");
            string newSymbol = textBoxReplace.Text.Replace(" ", "");
            string[] words = { };

            if (_text.Contains(oldSymbol))
            {
                _text = _text.Replace($" {oldSymbol} ", $"{oldSymbol}");
                _text = _text.Replace(oldSymbol, $" {oldSymbol} ");//Add space because of _text will be saparated for "words" array  recognize "oldSymbol"
                words = _text.Split(' ');
                int index = Array.IndexOf(words, oldSymbol);
                words[index] = newSymbol;
                //return _text = string.Join(" ", words);
                return string.Join(" ", words);
            }
            return _text;
        }

        public string ReplaceInCurrentPage(string _text)
        {
            string word = string.Empty;
            string newText = string.Empty;
            string oldSymbol = textBoxFind2.Text.Replace(" ", "");
            string newSymbol = textBoxReplace.Text.Replace(" ", "");

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
            return newText;
        }

        private void buttonFindNext_Click(object sender, EventArgs e)
        {

        }
        private void textBoxReplace_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonFindNext2_Click(object sender, EventArgs e)
        {

        }
    }
}
