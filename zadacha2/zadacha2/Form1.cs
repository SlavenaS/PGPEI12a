using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                label1.Text = "nula";
            }
            else if (textBox1.Text == "1")
            {
                label1.Text = "edno";
            }
            else if (textBox1.Text == "2")
            {
                label1.Text = "dve";
            }
            else if (textBox1.Text == "3")
            {
                label1.Text = "tri";
            }
            else if (textBox1.Text == "4")
            {
                label1.Text = "chetiri";
            }
            else if (textBox1.Text == "5")
            {
                label1.Text = "pet";
            }
            else if (textBox1.Text == "6")
            {
                label1.Text = "shest";
            }
            else if (textBox1.Text == "7")
            {
                label1.Text = "sedem";
            }
            else if (textBox1.Text == "8")
            {
                label1.Text = "osem";
            }
            else if (textBox1.Text == "9")
            {
                label1.Text = "devet";
            }
            else
            {
                MessageBox.Show("ne moje");
            }
        }
    }
}
