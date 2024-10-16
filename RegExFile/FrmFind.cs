using iTextSharp.text.pdf;
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
    public partial class FrmFind : Form
    {
        public FrmFind instance;
        public static Form1 form1;

        private string name = string.Empty;
        private int index = 0;
        private RichTextBox richTBox;
        private string readerPdf = string.Empty;
        private PageReadTxt readerTxt;
        private string[] arrSplit = { " ", ".", ",", "!", "?", "—", "'", "\'", "/", "„", "“", ":", "(", ")", ";", "«", "»", " ", "”", "\n", "\t" };
        private int currentIndexFromText = 0;
        private int getIndexFindNext = 0;
        private int startIndex = 0;
        private List<MarkText> lsMarkText = new List<MarkText>();
        //private int currentPositionRichTBox = 0;
        private StringBuilder sbMarkupText;
        private List<string> lsMarkupText;

        public FrmFind(Form1 f, RichTextBox richBox)
        {
            InitializeComponent();

            instance = this;
            form1 = f;
            this.richTBox = richBox;
            sbMarkupText = new StringBuilder();
            lsMarkupText = new List<string>();
            //currentPositionRichTBox = currentPositionRichTextBox;

            if (form1.pathWithFile.Count() > 0)
            {
                readerTxt = new PageReadTxt(form1.pathWithFile[0]);
            }
            else
            {
                return;
            }
        }
        private void Find_Load(object sender, EventArgs e)
        {
            //instance.TopMost = true;
            //instance.Focus();
        }
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            richTBox.Text = richTBox.Text;
            ReplaceNextWord(richTBox.Text);
            richTBox.Text = ReplaceNextWord(richTBox.Text);
        }
        public void buttonReplaceInCurrentPage_Click(object sender, EventArgs e)
        {
            if (checkBoxRegularExpression.Checked)
            {
                foreach (var word in lsMarkupText)
                {
                   richTBox.Text = richTBox.Text.Replace(word, textBoxReplace.Text);
                }
            }
            else
            {
                this.richTBox.Text = richTBox.Text;
                ReplaceInCurrentPage(richTBox.Text);
                richTBox.Text = ReplaceInCurrentPage(richTBox.Text);
                //labelInfo.Text = $"Info: {richTBox.Text.Count()} items modified";
            }
        }
        private void buttonReplaceAllKindInCurrentPage_Click(object sender, EventArgs e)
        {
            // If word have space or a dash "-", this button get together the word.
            // Exp: Корупцуя-та, Коруп цуята, Корупцуя та.
            // In "find" field write "Корупцията" and in "replace" field write "Корупцията". All same word will be repair and get together.
            // Result: Корупцията.


            string wordFind = textBoxFind2.Text.Replace(" ", "");
            string modelWord = textBoxReplace.Text;

            string text = richTBox.Text;
            int textLength = text.Length;
            string replacedWord = string.Empty;
            int countReplacementWords = 0;
            int countSpaces = 0;
            string findedWord = string.Empty;
            int k = 0;

            for (int j = 0; j < text.Length; j++)
            {
                if (text[j].ToString().ToLower() == wordFind[0].ToString().ToLower())
                {
                    replacedWord = "";
                    findedWord = "";
                    countSpaces = 0;

                    for (k = j; k < (j + wordFind.Length + countSpaces); k++)
                    {
                        string getLetter = text[k].ToString().Replace(" ", "");

                        if (getLetter == "")
                        {
                            findedWord += " ";
                            countSpaces++;
                        }
                        else if (getLetter == "-")
                        {
                            findedWord += "-";
                            countSpaces++;
                            continue;
                        }
                        else
                        {
                            if (modelWord.ToLower().Contains(getLetter[0].ToString().ToLower()))
                            {
                                bool isUpper = char.IsUpper(getLetter[0]);

                                if (isUpper)
                                {
                                    replacedWord += getLetter[0].ToString().ToUpper();
                                    //findedWord += getLetter[0];
                                }
                                else
                                {
                                    replacedWord += getLetter[0].ToString().ToLower();
                                    //findedWord += getLetter[0];
                                }
                                findedWord += getLetter[0];
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    if (replacedWord.ToLower() == wordFind.ToLower())
                    {
                        richTBox.Text = richTBox.Text.Replace(findedWord, modelWord);
                        countReplacementWords++;

                        j += wordFind.Length;
                    }
                    else
                    {
                        replacedWord = "";
                        findedWord = "";
                    }
                }
            }
            labelInfo.Text = $"{countReplacementWords} words replaced!";
        }

        private string ReplaceNextWord(string text)
        {
            string oldSymbol = textBoxFind2.Text.Replace(" ", "");
            string newSymbol = textBoxReplace.Text.Replace(" ", "");
            string[] words = { };

            if (oldSymbol.Length == 1 && newSymbol.Length == 1)
            {
                if (text.Contains(oldSymbol))
                {
                    text = text.Replace($" {oldSymbol} ", $"{oldSymbol}");
                    text = text.Replace(oldSymbol, $" {oldSymbol} ");//Add space because of _text will be saparated for "words" array  recognize "oldSymbol"
                    words = text.Split(' ');
                    int index = Array.IndexOf(words, oldSymbol);
                    words[index] = newSymbol;
                    //return _text = string.Join(" ", words);
                    return string.Join(" ", words);
                }

            }
            else
            {
                MessageBox.Show("Select One Character!");
            }
            return text;
        }

        public string ReplaceInCurrentPage(string _text)
        {
            string newText = string.Empty;

            if (!checkBoxRegularExpression.Checked)
            {
                int numberOfReplacements = 0;
                int countEqualsWordsBeforeReplacement = 0;

                string oldWord = textBoxFind2.Text;
                string newWord = textBoxReplace.Text;


                string[] arrWords = richTBox.Text.Split();

                for (int i = 0; i < arrWords.Length; i++)
                {
                    string currentWord = arrWords[i];

                    if (currentWord == newWord)
                    {
                        countEqualsWordsBeforeReplacement++;
                    }

                }
                newText = richTBox.Text.Replace(oldWord, newWord);

                string[] arrWordsAfterReplacements = newText.Split();

                for (int i = 0; i < arrWordsAfterReplacements.Length; i++)
                {
                    string word = arrWordsAfterReplacements[i];

                    if (word == newWord)
                    {
                        numberOfReplacements++;
                    }

                }
                int replacementWords = numberOfReplacements - countEqualsWordsBeforeReplacement;

                if (replacementWords == 0)
                {
                    replacementWords = 1;
                }

                labelInfo.Text = $"Info: {replacementWords} items modified";
                //return newText;
            }
            else
            {
                string text = richTBox.SelectedText;
                richTBox.SelectedText = text;
            }
            return newText;
        }

        private void buttonFindNext_Click(object sender, EventArgs e)
        {
            if (checkBoxRegularExpression.Checked)
            {
                string text = string.Empty;
                int startIndex = 0;
                if (form1.extension == "pdf")
                {
                    readerPdf = form1.ReadPdf(form1.pathWithFile[0].ToString());
                    text = readerPdf.ToString();
                }
                else if (form1.extension == "txt")
                {
                    readerTxt = new PageReadTxt(form1.pathWithFile[0]);
                    text = string.Join(" ", readerTxt.GetPages());
                }
                else
                {
                    text = form1.richTextBoxFileWindow.Text;
                }
                string[] lines = text.Split(' ', '\n', '\r', '\t', '.', ',');

                string pattern = $"{textBoxFind1.Text}";//.Replace(@"\s", "").Replace(@"\t", "").Replace(@"\n", "");

                foreach (var currentLine in lines)
                {
                    Match match = Regex.Match(currentLine, pattern);

                    while (match.Success)
                    {
                        if (currentLine != "")
                        {
                            name = match.Groups[1].Value;

                            int index = text.IndexOf(name, startIndex);
                            startIndex = index;
                            startIndex++;
                            if (index != 0 || index != -1)
                            {
                                //System.Drawing.Font fnt = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point);

                                richTBox.Select(index, name.Length);

                                //richTBox.SelectionFont = fnt;
                                richTBox.SelectionColor = System.Drawing.Color.Red;
                            }
                            match = match.NextMatch();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                richTBox.SelectionColor = System.Drawing.Color.Black;

                textBoxFind1.Text = textBoxFind1.Text.Replace(" ", "");
                string word = textBoxFind1.Text;
                //word = word.Replace(" ", "");
                //string[] words = form1.richTextBoxFileWindow.Text.Split(arrSplit, StringSplitOptions.RemoveEmptyEntries);
                //string text = richTBox.Text;
                //string getWord = string.Empty;
                //int indexOfWords = 0;

                getIndexFindNext = form1.richTextBoxFileWindow.Text.IndexOf(word, startIndex);

                if (getIndexFindNext != -1)
                {
                    richTBox.Select(getIndexFindNext, word.Length);
                    richTBox.SelectionColor = System.Drawing.Color.Red;
                    startIndex = getIndexFindNext;
                    startIndex++;
                }
                else
                {
                    startIndex = 0;
                }

                ////for (int i = 0; i < words.Length; i++)
                ////{
                //for (int j = currentIndexFromText; j < text.Length; j++)
                //{
                //    getWord += text[j];
                //    getWord = getWord.Replace(" ", "");

                //    currentIndexFromText++;

                //    if (getWord == "\n" || getWord == "")
                //    {
                //        getWord = "";
                //        continue;
                //    }

                //    if (getWord.Length > 1)
                //    {
                //        if (getWord == word)
                //        {
                //            richTBox.Select(currentIndexFromText - getWord.Length, getWord.Length);
                //            richTBox.SelectionColor = System.Drawing.Color.Red;

                //            getWord = "";
                //            return;
                //        }
                //    }
                //    for (int k = indexOfWords; k < words.Length; k++)
                //    {

                //        if (words[k] == getWord)
                //        {
                //            indexOfWords++;

                //            getWord = "";
                //            break;
                //        }
                //    }

                //}
                //if (currentIndexFromText == text.Length)
                //{
                //    currentIndexFromText = 0;
                //    indexOfWords = 0;
                //}
                //}
            }
        }
        private void textBoxReplace_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonFindNext2_Click(object sender, EventArgs e)
        {
            if (checkBoxRegularExpression.Checked)
            {
                string text = string.Empty;
                int startIndex = 0;
                if (form1.extension == "pdf")
                {
                    readerPdf = form1.ReadPdf(form1.pathWithFile[0].ToString());
                    text = readerPdf.ToString();
                }
                else if (form1.extension == "txt")
                {
                    readerTxt = new PageReadTxt(form1.pathWithFile[0]);
                    text = string.Join(" ", readerTxt.GetPages());
                }
                else
                {
                    text = form1.richTextBoxFileWindow.Text;
                }
                string[] lines = text.Split(' ', '\n', '\r', '\t', '.', ',');

                string pattern = $"{textBoxFind2.Text}";//.Replace(@"\s", "").Replace(@"\t", "").Replace(@"\n", "");

                foreach (var currentLine in lines)
                {
                    Match match = Regex.Match(currentLine, pattern);

                    while (match.Success)
                    {
                        if (currentLine != "")
                        {
                            name = match.Groups[1].Value;

                            int index = text.IndexOf(name, startIndex);
                            startIndex = index;
                            startIndex++;
                            if (index != 0 || index != -1)
                            {
                                //System.Drawing.Font fnt = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point);

                                richTBox.Select(index, name.Length);

                                //richTBox.SelectionFont = fnt;
                                richTBox.SelectionColor = System.Drawing.Color.Red;
                            }
                            match = match.NextMatch();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                richTBox.SelectionColor = System.Drawing.Color.Black;

                textBoxFind2.Text = textBoxFind2.Text.Replace(" ", "");
                string word = textBoxFind2.Text;
                getIndexFindNext = form1.richTextBoxFileWindow.Text.IndexOf(word, startIndex);

                if (getIndexFindNext != -1)
                {
                    richTBox.Select(getIndexFindNext, word.Length);
                    richTBox.SelectionColor = System.Drawing.Color.Red;
                    startIndex = getIndexFindNext;
                    startIndex++;
                }
                else
                {
                    startIndex = 0;
                }
            }
        }

        private void textBoxFind1_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxAnchor.Checked)
            {
                textBoxFind2.Text = textBoxFind1.Text;
                textBoxFind3.Text = textBoxFind1.Text;
            }
        }

        private void textBoxFind2_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxAnchor.Checked)
            {
                textBoxFind1.Text = textBoxFind2.Text;
                textBoxFind3.Text = textBoxFind2.Text;
            }
        }

        private void textBoxFind3_TextChanged(object sender, EventArgs e)
        {
            if (!checkBoxAnchor.Checked)
            {
                textBoxFind1.Text = textBoxFind3.Text;
                textBoxFind2.Text = textBoxFind3.Text;
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int counterEqualSymbols = 0;
            string word = textBoxFind1.Text;
            string[] words = form1.richTextBoxFileWindow.Text.Split(arrSplit, StringSplitOptions.RemoveEmptyEntries);
            string text = richTBox.Text;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    counterEqualSymbols++;
                }
            }
            labelInfo.Text = $"Info: {counterEqualSymbols}";
        }

        private void buttonFindAllinCurrentDocument_Click(object sender, EventArgs e)
        {
            string symbolOrWord = textBoxFind1.Text;
            List<string> lsText = new List<string>();
            string arrText = string.Empty;
            string text = string.Empty;
            int counter = 0;
            string[] getWord = { };

            if (form1.extension == "pdf")
            {
                arrText = form1.GetAllPdfText(form1.pathWithFile[0].ToString());
                text = arrText;
            }
            else if (form1.extension == "txt")
            {
                lsText = readerTxt.GetPages();

                foreach (string w in lsText)
                {
                    text += w;
                }
            }
            getWord = text.Split(' ', '\n');

            for (int i = 0; i < text.Length; i++)
            {
                counter = text.Where(c => c == (int)symbolOrWord[0]).Count();
            }
            labelInfo.Text = $"Info: {counter}";

            labelInfo.Text = $"Info: {counter}";
        }

        private void buttonClearAllMarks_Click(object sender, EventArgs e)
        {
            richTBox.SelectAll();
            richTBox.SelectionColor = System.Drawing.Color.Black;
            form1.richTextBoxFileWindow.SelectionBackColor = System.Drawing.Color.White;
            Clipboard.Clear();
        }

        private void checkBoxRegularExpression_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonMarkInCurrentPage_Click(object sender, EventArgs e)
        {
            if (checkBoxRegularExpression.Checked)
            {
                string text = string.Empty;
                int startIndex = 0;
                lsMarkText = new List<MarkText>();

                if (form1.extension == "pdf")
                {
                    readerPdf = form1.ReadPdf(form1.pathWithFile[0].ToString());
                    text = readerPdf.ToString();
                }
                else if (form1.extension == "txt")
                {
                    readerTxt = new PageReadTxt(form1.pathWithFile[0]);
                    text = string.Join(" ", readerTxt.GetPages());
                }
                else
                {
                    text = form1.richTextBoxFileWindow.Text;
                }
                string[] lines = text.Split(' ', '\n', '\r', '\t', '.', ',');

                string pattern = $"{textBoxFind3.Text}";//.Replace(@"\s", "").Replace(@"\t", "").Replace(@"\n", "");

                foreach (var currentLine in lines)
                {
                    Match match = Regex.Match(currentLine, pattern);

                    while (match.Success)
                    {
                        if (currentLine != "")

                        {
                            name = match.Groups[1].Value;

                            int index = text.IndexOf(name, startIndex);
                            startIndex = index;
                            startIndex++;

                            if (index != 0 || index != -1)
                            {
                                MarkText markText = new MarkText();
                                markText.Index = index;
                                markText.Length = name.Length;
                                lsMarkText.Add(markText);

                                richTBox.Select(index, name.Length);

                                //System.Drawing.Font fnt = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, GraphicsUnit.Point);
                                //richTBox.SelectionFont = fnt;
                                richTBox.SelectionColor = System.Drawing.Color.Red;
                            }
                            match = match.NextMatch();
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                richTBox.SelectAll();
                richTBox.SelectionColor = System.Drawing.Color.Black;
                string markWord = textBoxFind3.Text;
                markWord = markWord.Replace(" ", "");

                string text = richTBox.Text;
                string getWord = string.Empty;
                int counterIndex = 0;
                int countWords = 0;

                if (markWord != "")
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        char currentWord = text[i];
                        getWord += text[i];
                        counterIndex++;
                        if (currentWord == ' ' || currentWord == '\n')
                        {
                            getWord = string.Empty;
                        }

                        if (getWord == markWord)
                        {
                            //if (text[i + 1] == ' ' || text[i + 1] == '.' || text[i + 1] == ',' || text[i + 1] == ')')
                            //{
                            counterIndex -= markWord.Length;

                            richTBox.Select(counterIndex, markWord.Length);
                            //richTBox.SelectionColor = System.Drawing.Color.RoyalBlue;
                            richTBox.SelectionColor = System.Drawing.Color.Red;

                            //=================For MarkupText Fill List<MarkText> ==========================
                            MarkText markText = new MarkText();
                            markText.Index = counterIndex;
                            markText.Length = getWord.Length;
                            lsMarkText.Add(markText);
                            //===============================================================================
                            getWord = string.Empty;
                            counterIndex += markWord.Length;
                            countWords++;
                            //}
                        }
                    }
                    labelInfo.Text = $"Info: {countWords} words marked";
                }
            }
        }
        private void buttonRemoveSpace_Click(object sender, EventArgs e)
        {
            string getWord = textBoxReplace.Text;
            textBoxReplace.Text = getWord.Replace(" ", "");
        }

        private void buttonCopyMarketText_Click(object sender, EventArgs e)
        {
            StringBuilder sbSelectedText = new StringBuilder();

            form1.richTextBoxFileWindow.SelectionBackColor = System.Drawing.Color.White;

            foreach (var currentText in lsMarkText)
            {
                form1.richTextBoxFileWindow.Select(currentText.Index, currentText.Length);

                form1.richTextBoxFileWindow.SelectionBackColor = System.Drawing.Color.Blue;

                lsMarkupText.Add(form1.richTextBoxFileWindow.SelectedText);
            }

            foreach (var currentText in lsMarkupText)
            {
                sbSelectedText.Append(currentText + " ");
            }

            lsMarkupText.Clear();

            Clipboard.Clear();
            Clipboard.SetText(sbSelectedText.ToString());

        }
    }
}
