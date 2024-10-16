using Microsoft.EntityFrameworkCore.Internal;
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
    public partial class FrmConvertLetters : Form
    {
        public static Form1 form1;
        private RichTextBox richTBox;
        public FrmConvertLetters(RichTextBox richTextBox)
        {
            InitializeComponent();
            form1 = new Form1();
            richTBox = richTextBox;
        }

        private void buttonConvert_Click(object sender, EventArgs e)//Convert In Page
        {
            string text = richTBox.Text;

            char[] arrBgLetters =
                { 'А', 'В', 'С', 'Е', 'Н', 'К', 'М', 'О', 'Р', 'Т', 'Х', 'У', 'а', 'с', 'е', 'к', 'т', 'п', 'о', 'р', 'х', 'у' };

            char[] arrEnLetters =
                { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y', 'a', 'c', 'e', 'k', 'm', 'n', 'o', 'p', 'x', 'y' };

            char[] arrSelectedEnLetters = new char[arrEnLetters.Length];
            char[] arrSelectedBgLetters = new char[arrBgLetters.Length];

            foreach (var item in checkedListBoxLetters.CheckedItems)
            {
                for (int i = 0; i < arrEnLetters.Length; i++)
                {
                    if (item.ToString() == arrEnLetters[i].ToString())
                    {
                        arrSelectedEnLetters[i] = arrEnLetters[i];
                        arrSelectedBgLetters[i] = arrBgLetters[i];
                    }
                }
            }

            if (text != "")
            {
                for (int i = 0; i < arrBgLetters.Length; i++)
                {
                    if (comboBoxConvertFrom.Text == "En" && comboBoxConvertTo.Text == "Bg")
                    {
                        if (text.Contains(arrSelectedEnLetters[i]))
                        {
                            richTBox.Text = richTBox.Text.Replace(arrSelectedEnLetters[i], arrSelectedBgLetters[i]);
                        }
                    }
                    else if (comboBoxConvertFrom.Text == "Bg" && comboBoxConvertTo.Text == "En")
                    {
                        if (text.Contains(arrSelectedBgLetters[i]))
                        {
                            richTBox.Text = richTBox.Text.Replace(arrSelectedBgLetters[i], arrSelectedEnLetters[i]);
                        }
                    }
                }
                MessageBox.Show("Done!");
            }
        }

        private void comboBoxConvertFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxConvertFrom.SelectedItem.ToString() == "En")
            {
                comboBoxConvertTo.Text = "Bg";
            }
            else if (comboBoxConvertFrom.SelectedItem.ToString() == "Bg")
            {
                comboBoxConvertTo.Text = "En";
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            string[] arrLetters = { "A", "B", "C", "E", "H", "K", "M", "O", "P", "T", "X", "Y", "a", "c", "e", "k", "m", "n", "o", "p", "x", "y" };

            if (checkBoxAll.Checked)
            {

                for (int i = 0; i < arrLetters.Length; i++)
                {
                    checkedListBoxLetters.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < arrLetters.Length; i++)
                {
                    checkedListBoxLetters.SetItemChecked(i, false);
                }
            }
        }

        private void checkedListBoxLetters_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
