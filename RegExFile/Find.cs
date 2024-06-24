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
        Form1 form1 = new Form1();
        public string _text = string.Empty;
        private string name = string.Empty;
        private int index = 0;
        public static Find instance;
        public Label lab1;
        //public TextBox txtBox;

        //public Find(string text)
        public Find(Form1 f, string text)
        {
            InitializeComponent();
            //form1 = new Form1();        
            this._text = text;
            instance = this;
            lab1 = label5;
            form1 = f;
            //txtBox = textBoxTest;
        }

        public void buttonReplaceInCurrentPage_Click(object sender, EventArgs e)
        {
            this._text = form1.richTextBoxFileWindow.Text;
            ReplaceInCurrentPage(_text);

            form1.richTextBoxFileWindow.Text = ReplaceInCurrentPage(_text);
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            form1.richTBox.Text = ReplaceNextWord();
            //form1.Show();
        }

        private string ReplaceNextWord()
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
                return _text = string.Join(" ", words);
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

        private void buttonSendToFormTest_Click(object sender, EventArgs e)
        {
            //FormTest formTest = new FormTest();
            //formTest.Show();

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //Form1.instance.textBox2.Text = textBoxFind1.Text;

            //FormTest.instance.richTextBoxTest.Text = textBoxTest.Text;
            form1.richTBox.Text = textBoxTest.Text;
            form1.textBox2.Text = textBoxTest.Text;

        }

        private void textBoxTest_TextChanged(object sender, EventArgs e)
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
