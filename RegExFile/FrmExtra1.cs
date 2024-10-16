using iTextSharp.text;
using SixLabors.ImageSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExFile
{
    public partial class FrmExtra1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref System.Drawing.Point lpPoint);

        public static FrmExtra1 instance;
        public static Form1 form1;
        private static List<string> lsContent;
        private RichTextBox richTBox;
        private string[] pathWithFile = { };
        private int getCharIndexPosition;
        //private static extern bool GetCursorPos(ref System.Drawing.Point lpPoint);

        public FrmExtra1(Form1 inst, RichTextBox richText, string[] pathWithFileFromForm1, int getCharIndexFromPosition)
        {
            InitializeComponent();

            instance = this;
            form1 = new Form1();
            form1 = inst;
            lsContent = new List<string>();
            //richTBoxTex = new RichTextBox();
            richTBox = richText;
            this.pathWithFile = pathWithFileFromForm1;
            getCharIndexPosition = getCharIndexFromPosition;

            //buttonToUpper.Click += buttonToUpper_Click;
            //buttonToLower.Click += buttonToLower_Click;
        }
        public FrmExtra1()
        {

        }
        private void FrmExtra1_Load(object sender, EventArgs e)//Stay Form duration working with another form
        {
            //instance.TopMost = true;
            instance.Focus();
        }
        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            if (richTBox.SelectedText != "")
            {
                //richTBox.Text = ToUpper(richTBox.SelectedText);
                ToUpper(richTBox.SelectedText);

                form1.labelItems.Text = $"Items: {form1.lsGetToUpperContent.Count}";

                checkBoxSelectAllInPage.Checked = false;
            }
        }
        private void buttonToLower_Click(object sender, EventArgs e)
        {
            if (richTBox.SelectedText != "")
            {
                //richTBox.Text = ToLower(richTBox.SelectedText);
                ToLower(richTBox.SelectedText);

                form1.labelItems.Text = $"Items: {form1.lsGetToUpperContent.Count}";

                checkBoxSelectAllInPage.Checked = false;
            }
        }
        private void buttonAbc_Click(object sender, EventArgs e)
        {
            //Abc(form1.richTextBoxFileWindow.Text);
            if (richTBox.SelectedText != "")
            {
                //richTBox.Text = Abc(richTBox.Text, richTBox.SelectedText);
                Abc(richTBox.Text, richTBox.SelectedText);
                form1.labelItems.Text = $"Items: {form1.lsGetToLowerContent.Count}";

                //checkBoxForAllDocument.Checked = false;
                checkBoxSelectAllInPage.Checked = false;
            }
        }
        private void ToUpper(string selectedText)
        {
            string toUpper = string.Empty;

            if (selectedText != "")
            {
                //string selectedText = form1.richTextBoxFileWindow.SelectedText;

                if (this.checkBoxForAllDocument.Checked)
                {
                    toUpper = FillToUpper();

                    richTBox.Text = toUpper;
                }
                else
                {
                    //return form1.richTextBoxFileWindow.Text = selectedText;
                    //return richTBox.Text.Replace(selectedText, selectedText.ToUpper());
                    richTBox.SelectedText = richTBox.SelectedText.Replace(selectedText, selectedText.ToUpper());
                }
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
            checkBoxForAllDocument.Checked = false;

            //return string.Join(" ", richTBox.Text = toUpper);// toUpper);// form1.lsGetToUpperContent); 

        }
        public void LowerSelectedString(RichTextBox richTextBox)
        {
            if (richTBox.SelectedText.Length > 0)
            {
                int startIndex = richTBox.SelectionStart;
                int length = richTBox.SelectionLength;

                // Get the original text and lowercase the selected portion
                string originalText = richTBox.Text;
                string loweredText = originalText.Substring(startIndex, length).ToLower();

                // Replace the selected text with the lowered version
                richTBox.Text = originalText.Remove(startIndex, length).Insert(startIndex, loweredText);

                // Restore selection to the lowered text
                richTextBox.Select(startIndex, loweredText.Length);
            }
        }
        private void ToLower(string selectedText)
        {
            string toLower = string.Empty;

            if (selectedText != "")
            {
                if (checkBoxForAllDocument.Checked)
                {
                    toLower = FillToLower();

                    richTBox.Text = toLower;
                }
                else
                {
                    //return richTBox.Text.Replace(selectedText, selectedText.ToLower());
                    richTBox.SelectedText = richTBox.SelectedText.Replace(selectedText, selectedText.ToLower());
                }

            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
            checkBoxForAllDocument.Checked = false;

            //return string.Join(" ", richTBox.Text = toLower);// toLower);// form1.lsGetToLowerContent);
            //string.Join(" ", richTBox.Text = toLower);// toLower);// form1.lsGetToLowerContent);
        }
        private string FillToUpper()
        {
            form1.richTextBoxFileWindow.Text = "";
            form1.lsGetToUpperContent.Clear();

            //string path = pathWithFile;// form1.GetPath();

            PageReadTxt reader = new PageReadTxt(pathWithFile[0]);

            lsContent = reader.GetPages();

            foreach (var page in lsContent)
            {
                form1.lsGetToUpperContent.Add(page.ToString().ToUpper());
            }
            return string.Join("", form1.lsGetToUpperContent);
        }
        private string FillToLower()
        {
            form1.richTextBoxFileWindow.Text = "";
            form1.lsGetToLowerContent.Clear();

            //string path = pathWithFile;// form1.GetPath();

            PageReadTxt reader = new PageReadTxt(pathWithFile[0]);

            List<string> lsContent = new List<string>();
            lsContent = reader.GetPages();

            foreach (var page in lsContent)
            {
                form1.lsGetToLowerContent.Add(page.ToString());
            }
            return string.Join("", lsContent);// form1.lsGetToLowerContent);
        }



        private void Abc(string getText, string selectedText)
        {
            //string text = FillToLower();
            string text = string.Empty;
            string[] arrText = { };
            string getWord = string.Empty;
            string newWord = string.Empty;

            if (checkBoxForAllDocument.Checked)
            {
                //string word = form1.richTextBoxFileWindow.SelectedText;
                text = FillToLower();
                arrText = text.Split('\n', ' ');

                for (int i = 0; i < arrText.Length; i++)
                {
                    getWord = arrText[i].ToString();//First letter toUpper

                    if (getWord.Length > 0)
                    {
                        newWord += getWord[0].ToString().ToUpper();
                        newWord += getWord.Substring(1, getWord.Length - 1).ToLower() + "\n";//Other letters toLower
                    }
                    else
                    {
                        newWord += "\n";
                    }
                }
            }
            else if (checkBoxSelectAllInPage.Checked)
            {
                arrText = selectedText.Split('\n');

                for (int i = 0; i < arrText.Length; i++)
                {
                    getWord = arrText[i];//First letter toUpper

                    if (getWord.Length > 0)
                    {
                        newWord += getWord[0].ToString().ToUpper();
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
                if (getText != "")
                {
                    //string word = form1.richTextBoxFileWindow.SelectedText;

                    newWord = selectedText[0].ToString().ToUpper();//First letter toUpper
                    newWord += selectedText.Substring(1, selectedText.Length - 1).ToLower();//Other letters toLower

                    //form1.richTextBoxFileWindow.Text.Replace(selectedText, newWord);
                }
                else
                {
                    MessageBox.Show("Select Text Please!");
                }
                string newText = getText.Replace(selectedText, newWord);

                //return newText;

            }
            checkBoxForAllDocument.Checked = false;

            richTBox.SelectedText = newWord;
        }

        private void checkBoxForAllDocument_CheckedChanged_1(object sender, EventArgs e)
        {
            checkBoxForAllDoc();
        }
        public bool checkBoxForAllDoc()
        {
            if (checkBoxForAllDocument?.Checked != null)
            {
                checkBoxSelectAllInPage.Checked = false;

                richTBox.SelectAll();
                richTBox.SelectionColor = Color.RoyalBlue;
            }
            if (checkBoxForAllDocument?.Checked == false)
            {
                richTBox.SelectionColor = Color.Black;
            }

            return true;
        }

        private void checkBoxSelectAllInPage_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAllInPage?.Checked != null)
            {
                checkBoxForAllDocument.Checked = false;

                richTBox.SelectAll();
                richTBox.SelectionColor = Color.RoyalBlue;
            }
            if (checkBoxSelectAllInPage?.Checked == false)
            {
                richTBox.SelectionColor = Color.Black;
            }
        }

        private void buttonRemoveSpaces_Click(object sender, EventArgs e)
        {
            if (richTBox.SelectedText != "")
            {
                //string[] removeSpaces = richTBoxTex.SelectedText.Split(' ');
                //string newWord = string.Empty;
                //for (int i = 0; i < removeSpaces.Length; i++)
                //{
                //    newWord += removeSpaces[i].Replace(" ", "");
                //}
                //richTBoxTex.SelectedText = newWord;
                string removeSpaces = richTBox.SelectedText;
                string newWord = string.Empty;

                newWord = removeSpaces.Replace(" ", "");

                richTBox.SelectedText = newWord;
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
        }

        private void buttonRemoveEquals_Click(object sender, EventArgs e)
        {
            //string[] arrText = richTBox.Text.Split();
            //char[] symbols = richTBox.SelectedText.ToCharArray();
            string getSelectedText = richTBox.SelectedText;

            if (getSelectedText.Length > 0)
            {
                //string allText = richTBox.Text;
                //richTBox.Text = "";
                //string text = string.Empty;

                //if (getSelectedText.Length == 1)
                //{
                //for (int i = 0; i < allText.Length; i++)
                //{
                //    for (int j = 0; j < symbols.Length; j++)
                //    {
                //        if (allText[i] != symbols[j])
                //        {
                //            text += allText[i];
                //        }
                //    }
                //}
                //allText = allText.Replace(getSelectedText, "");

                //===================================================
                //string removeSpaces = richTBox.SelectedText;
                //string newWord = string.Empty;

                //newWord = removeSpaces.Replace(" ", "");

                //richTBox.SelectedText = newWord;
                //===================================================

                //richTBox.SelectAll();

                //int index = richTBox.Text.IndexOf(getSelectedText);
                int cursorIndex = richTBox.SelectionStart;



                string newText = richTBox.Text.Replace(getSelectedText, "");
                //richTBox.Text = "";
                richTBox.Text = newText;

                //==================================================================
                //int charIndex = richTBox.GetCharIndexFromPosition(e.Location);

                //// Get the line number from the character index
                //int lineNumber = richTBox.GetLineFromCharIndex(cursorIndex);

                //// Get the starting index of the clicked line
                //int lineStart = richTBox.GetFirstCharIndexFromLine(lineNumber);

                //// Get the starting index of the next line
                //int lineEnd = (lineNumber + 1 < richTBox.Lines.Length) ?
                //    richTBox.GetFirstCharIndexFromLine(lineNumber + 1) :
                //    richTBox.TextLength;

                //// Calculate the length of the line
                //int lineLength = lineEnd - lineStart;
                //==================================================================


                richTBox.SelectionStart = cursorIndex;// + lineLength;


                //}
                //else
                //{
                //    MessageBox.Show("Select One Symbol!");
                //}
            }
            else
            {
                MessageBox.Show("Select Text Please!");
            }
        }


        private void buttonIsCyrillic_Click(object sender, EventArgs e)
        {
            string letter = richTBox.SelectedText;

            if (letter.Length == 1)
            {
                decimal decimalNumber = letter[0];


                if (decimalNumber >= 1040 && decimalNumber <= 1103)
                {
                    labelInfo.Text = $"Info: '{letter[0]}' - Is Cyrillic";
                }
                else
                {
                    labelInfo.Text = $"Info: '{letter[0]}' - Not Cyrillic";
                }
            }
            else
            {
                MessageBox.Show("Select One Letter!");
            }
        }


    }
}
