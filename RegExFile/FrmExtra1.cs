using iTextSharp.text;
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
    public partial class FrmExtra1 : Form
    {
        public static FrmExtra1 instance;
        public static Form1 form1 = new Form1();
        private static List<string> lsContent = new List<string>();
        public FrmExtra1(Form1 inst)
        {
            InitializeComponent();

            instance = this;
            form1 = inst;
        }
        public FrmExtra1()
        {

        }
        private void FrmExtra1_Load(object sender, EventArgs e)//Stay Form duration working with another form
        {
            instance.TopMost = true;
        }
        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            form1.richTextBoxFileWindow.Text = ToUpper();
        }
        private void buttonToLower_Click(object sender, EventArgs e)
        {
            form1.richTextBoxFileWindow.Text = ToLower();
        }
        private string ToUpper()
        {
            string toUpper = string.Empty;

            if (form1.richTextBoxFileWindow.SelectedText != "")
            {
                string selectedText = form1.richTextBoxFileWindow.SelectedText;

                if (this.checkBoxForAllDocument.Checked)
                {
                    toUpper = FillToUpper();
                    form1.richTextBoxFileWindow.Text = toUpper.ToUpper();
                }
                else
                {
                    //return form1.richTextBoxFileWindow.Text = selectedText;
                    return form1.richTextBoxFileWindow.Text.Replace(selectedText, selectedText.ToUpper());
                }
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
            checkBoxForAllDocument.Checked = false;
            return string.Join(" ", form1.richTextBoxFileWindow.Text = toUpper.ToUpper());// toUpper);// form1.lsGetToUpperContent); 

        }
        private string ToLower()
        {
            string toLower = string.Empty;

            if (form1.richTextBoxFileWindow.SelectedText != "")
            {
                string selectedText = form1.richTextBoxFileWindow.SelectedText;

                if (checkBoxForAllDocument.Checked)
                {
                    toLower = FillToLower();
                    form1.richTextBoxFileWindow.Text = toLower.ToLower();
                    //DisplayPages(pageSize, lsGetToUpperContent, count);
                }
                else
                {
                    return form1.richTextBoxFileWindow.Text.Replace(selectedText, selectedText.ToLower());
                }
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
            checkBoxForAllDocument.Checked = false;
            return string.Join(" ", form1.richTextBoxFileWindow.Text = toLower.ToLower());// toLower);// form1.lsGetToLowerContent);
        }
        private static string FillToUpper()
        {
            //int pageSize = 40;
            //int count = 0;

            form1.richTextBoxFileWindow.Text = "";

            var reader = new PageReadTxt(form1.pathWithFile[0]);

            lsContent = reader.GetPages();

            foreach (var page in lsContent)
            {
                form1.lsGetToUpperContent.Add(page.ToString().ToUpper());
            }
            return string.Join(" ", form1.lsGetToUpperContent);
        }



        private static string FillToLower()
        {
            //int pageSize = 40;
            //int count = 0;

            form1.richTextBoxFileWindow.Text = "";

            var reader = new PageReadTxt(form1.pathWithFile[0]);
            List<string> lsContent = new List<string>();
            lsContent = reader.GetPages();

            foreach (var page in lsContent)
            {
                form1.lsGetToLowerContent.Add(page.ToString().ToLower());
            }
            return string.Join(" ", lsContent);// form1.lsGetToLowerContent);
        }

        private void buttonAbc_Click(object sender, EventArgs e)
        {
            //Abc(form1.richTextBoxFileWindow.Text);
            form1.richTextBoxFileWindow.Text = Abc(form1.richTextBoxFileWindow.SelectedText);
        }

        private string Abc(string selectedWord)
        {
            string text = FillToLower();
            string[] arrText = text.Split(' ');
            string getWord = string.Empty;
            string newWord = string.Empty;

            if (checkBoxForAllDocument.Checked)
            {
                //string word = form1.richTextBoxFileWindow.SelectedText;

                for (int i = 0; i < arrText.Length; i++)
                {
                    getWord = arrText[i].Replace("\n", "");//First letter toUpper

                    //for (int j = 0; j < getWord.Length; j++)
                    //{
                    newWord += getWord[0].ToString().ToUpper();
                    //}
                    if (getWord.Length > 1)
                    {
                        newWord += getWord.Substring(1, getWord.Length - 1).ToLower() + "\n";//Other letters toLower
                    }
                    else
                    {
                        newWord += "\n";
                    }
                }
            }
            else
            {
                if (selectedWord != "")
                {
                    string word = selectedWord;// form1.richTextBoxFileWindow.SelectedText;

                    newWord = word[0].ToString().ToUpper();//First letter toUpper
                    newWord += word.Substring(1, word.Length - 1).ToLower();//Other letters toLower

                    newWord = form1.richTextBoxFileWindow.Text.Replace(selectedWord, newWord);// form1.richTextBoxFileWindow.Text.Replace(getText, newWord);
                }
                else
                {
                    MessageBox.Show("Select Text Please!");
                }
                checkBoxForAllDocument.Checked = false;
                return newWord;

            }
            checkBoxForAllDocument.Checked = false;
            return form1.richTextBoxFileWindow.SelectedText = newWord;
        }

        private void checkBoxForAllDocument_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxForAllDocument.Checked)
            {
                Form1.instance.richTextBoxFileWindow.SelectAll();
                Form1.instance.richTextBoxFileWindow.SelectionColor = Color.RoyalBlue;
            }
            else
            {
                Form1.instance.richTextBoxFileWindow.SelectionColor = Color.Black;
            }
        }


    }
}
