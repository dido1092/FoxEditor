using DocumentFormat.OpenXml.ExtendedProperties;
using Microsoft.Office.Interop.Word;
using RegExFile.GetId;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static IronOcr.OcrResult;

namespace RegExFile
{
    public partial class FrmDatabase : Form
    {
        public static RegExFileContext context = new RegExFileContext();
        public FrmDatabase()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            progressBarImport.Maximum = 0;

            OpenFile();

            if (comboBoxDBLanguage.Text == "BG")
            {
                HashSet<string> hsBgWords = InsertIntoHashSetBg();

                InsertInTableBg(hsBgWords);
            }
            else if (comboBoxDBLanguage.Text == "EN")
            {
                HashSet<string> hsEnWords = InsertIntoHashSetEn();

                InsertInTableEn(hsEnWords);
            }
            else if (comboBoxDBLanguage.Text == "EN_Transcript")
            {
                HashSet<EnWordsTranscript> hsEnWordsTranscript = InsertIntoHashSetEnTranscript();

                InsertInTableEnTranscript(hsEnWordsTranscript);
            }
        }
        private void OpenFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxInsert.Text = openFileDialog1.FileName;
            }
        }
        private void InsertInTableBg(HashSet<string> hsBgWords)
        {
            progressBarImport.Minimum = 0;
            progressBarImport.Maximum = hsBgWords.Count();

            var src = DateTime.Now;

            foreach (var bgWord in hsBgWords.OrderBy(bgW => bgW))
            {
                BgWords wBg = new BgWords()
                {
                    BgWord = bgWord,
                    Length = bgWord.Length,
                    DateTime = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0),
                };
                context.BgWords.Add(wBg);

                progressBarImport.Value++;
            }
            context.SaveChanges();
            MessageBox.Show("Import Done!");
        }
        private void InsertInTableEn(HashSet<string> hsEnWords)
        {
            progressBarImport.Minimum = 0;
            progressBarImport.Maximum = hsEnWords.Count();

            var src = DateTime.Now;

            foreach (var enWord in hsEnWords)
            {
                EnWords wEn = new EnWords()
                {
                    EnWord = enWord,
                    Length = enWord.Length,
                    DateTime = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0),
                };

                context.EnWords.Add(wEn);

                progressBarImport.Value++;
            }

            context.SaveChanges();

            MessageBox.Show("Import Done!");
        }
        private void InsertInTableEnTranscript(HashSet<EnWordsTranscript> hsEnWordsTranscript)
        {
            progressBarImport.Minimum = 0;
            progressBarImport.Maximum = hsEnWordsTranscript.Count();

            var src = DateTime.Now;

            foreach (var enWord in hsEnWordsTranscript)
            {
                EnWordsTranscript wEnTranscript = new EnWordsTranscript()
                {
                    EnWord = enWord.EnWord,
                    Type = enWord.Type,
                    Description = enWord.Description,
                    Length = enWord.Length,
                    DateTime = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0),
                };

                context.EnWordsTranscript.Add(wEnTranscript);

                progressBarImport.Value++;
            }

            context.SaveChanges();

            MessageBox.Show("Import Done!");
        }
        private HashSet<string> InsertIntoHashSetBg()
        {
            HashSet<string> hsBgWords = new HashSet<string>();
            //string patternBg = @"([А-Я]+)";
            string[] lines = System.IO.File.ReadAllLines(textBoxInsert.Text.ToUpper());

            var bgWords = context.BgWords.Select(w => w.BgWord).ToHashSet();

            foreach (var line in lines)
            {
                string[] words = line.Split(' ', '.', ',', '!', '?', '"', '\'', '/', '„', '“', ':', '(', ')', ';', '«', '»', '=', '~', '♦', '•');

                for (int i = 0; i < words.Length; i++)
                {
                    string bgWord = words[i].Replace(" ", "").ToUpper();

                    if (bgWord.Length > 1)
                    {
                        string word = string.Empty;

                        for (int j = 0; j < bgWord.Length; j++)
                        {
                            int letter = bgWord[j];

                            if (letter >= 1040 && letter <= 1103 && bgWord[j] != ' ')
                            {
                                word += bgWord[j];
                            }
                        }
                        if ((!bgWords.Contains(bgWord)) && word.Length == bgWord.Length && word.Length > 0)
                        {
                            hsBgWords.Add(bgWord);
                        }
                    }
                    //if (Regex.Matches(bgWord, patternBg).Count > 0 && bgWord.Length > 1)
                    //{
                    //    if (!bgWords.Contains(bgWord))
                    //    {
                    //        hsBgWords.Add(bgWord);
                    //    }
                    //    else
                    //    {
                    //        //MessageBox.Show($"Duplicate word \"{bgWord}\"");
                    //    }
                    //}
                }
            }

            return hsBgWords;
        }
        private HashSet<string> InsertIntoHashSetEn()
        {
            HashSet<string> hsEnWords = new HashSet<string>();
            //string patternEn = @"([a-zA-Z]+)";
            string[] lines = System.IO.File.ReadAllLines(textBoxInsert.Text.ToUpper());

            var enWords = context.EnWords.Select(w => w.EnWord).ToHashSet();

            foreach (var line in lines)
            {
                string[] words = line.Split(' ', '.', ',', '!', '?', '"', '—', '-', '\'', '/', '„', '“', ':', '(', ')', ';', '«', '»', '=', '~', '♦', '•', '©', '®', '[', ']', '&', '‘', '”', '{', '}', '^', '#');

                for (int i = 0; i < words.Length; i++)
                {
                    string enWord = words[i].Replace(" ", "").ToUpper();

                    if (enWord.Length > 1)
                    {
                        string word = string.Empty;

                        for (int j = 0; j < enWord.Length; j++)
                        {
                            int letterEn = (int)enWord[j];

                            if ((letterEn >= (char)48 && letterEn <= (char)57) || (letterEn >= (char)65 && letterEn <= (char)90) || (letterEn >= (char)97 && letterEn <= (char)122) || letterEn == '\'' || letterEn == '-')
                            {
                                word += enWord[j];
                            }
                        }
                        if ((!enWords.Contains(enWord)) && word.Length == enWord.Length && word.Length > 0)
                        {
                            hsEnWords.Add(enWord);
                        }
                    }

                    //if (Regex.Matches(enWord, patternEn).Count > 0 && enWord.Length > 1)
                    //{
                    //    if (!enWords.Contains(enWord))
                    //    {
                    //        hsEnWords.Add(enWord);
                    //    }
                    //    else
                    //    {
                    //        //MessageBox.Show($"Duplicate word \"{bgWord}\"");
                    //    }
                    //}
                }
            }

            return hsEnWords;
        }
        private HashSet<EnWordsTranscript> InsertIntoHashSetEnTranscript()
        {
            HashSet<EnWordsTranscript> hsEnWords = new HashSet<EnWordsTranscript>();

            string[] lines = System.IO.File.ReadAllLines(textBoxInsert.Text.ToUpper());

            var getEnWordsTranscript = context.EnWordsTranscript.Select(w => w.EnWord).ToHashSet();

            foreach (var line in lines)
            {
                string pattern = @"(?<name>['-w\ \w]+\w \s)(?<type>.+?)\s+(?<description>.+)";

                Match match = Regex.Match(line, pattern);

                if (match.Success)
                {
                    EnWordsTranscript enWordsTranscript = new EnWordsTranscript();

                    if (match.Groups["name"].Value != null)
                    {
                        //enWordsTranscript.EnWord = enWordName;
                        enWordsTranscript.EnWord = match.Groups["name"].Value;
                    }
                    if (match.Groups["type"].Value != null)
                    {
                        //enWordsTranscript.Type = enWordType;
                        enWordsTranscript.Type = match.Groups["type"].Value;
                    }
                    if (match.Groups["description"].Value != null)
                    {
                        enWordsTranscript.Description = match.Groups["description"].Value;
                    }

                    enWordsTranscript.Length = match.Groups["name"].Value.Length;

                    hsEnWords.Add(enWordsTranscript);
                }
            }

            return hsEnWords;
        }
        private void buttonShowDB_Click(object sender, EventArgs e)
        {
            if (comboBoxDBLanguage.Text == "BG")
            {
                FrmBgDB frmBgDB = new FrmBgDB();
                frmBgDB.Show();
            }
            else if (comboBoxDBLanguage.Text == "EN")
            {
                FrmEnDB frmEnDB = new FrmEnDB();
                frmEnDB.Show();
            }
        }
    }
}
