using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int uzunluk = textBox1.TextLength;
            int deger = uzunluk * 100 / textBox1.MaxLength;
            progressBar1.Value = deger;
            label1.Text = "% " + progressBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 150;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 5;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

       
    }
}
