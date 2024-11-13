using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt1 = textBox1.Text;
            double chsilo1 = Convert.ToDouble(txt1);

            string txt2 = textBox2.Text;
            double chsilo2 = Convert.ToDouble(txt2);

            double sum = chsilo1 + chsilo2;
            listBox2.Items.Add(sum);

            if(chsilo1 > chsilo2)
            {
                listBox1.Items.Add(chsilo1);
            }
            else if (chsilo2 > chsilo1)
            {
                listBox1.Items.Add(chsilo2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var minVal = listBox1.Items.Cast<string>().Select(int.Parse).Min();
                MessageBox.Show("min chislo" + minVal);
            }
            catch
            {
                MessageBox.Show("non numeric");
            }
        }
    }
}
