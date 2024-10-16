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
    public partial class FrmLines : Form
    {
        public int lines = 0;
        //public Form1 form1;
        public static FrmLines instance;
        public FrmLines(int lines)
        {
            this.lines = lines;
            //form1 = new Form1();
            instance = this;
            InitializeComponent();
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            lines = int.Parse(comboBoxLines.Text);
            instance.Close();
        }

        private void FrmLines_Load(object sender, EventArgs e)
        {
            //instance.TopMost = true;
        }
    }
}
