using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            double Akv = double.Parse(textBox1.Text);
            double Bkv = double.Parse(textBox2.Text);
            double Ckv = double.Parse(textBox3.Text);
            if (rbKvadrat.Checked)
            {
                double perimeturKv = Akv + Bkv + Ckv+Akv;
                double liceKv = Akv*Akv;

                label4.Text = "Perimetur: " + perimeturKv.ToString();
                label5.Text = "Lice:" + liceKv.ToString();
            }
            if (rbPravougulnik.Checked)
            {
                double perimeturPv = 2*(Akv + Bkv);
                double licePv = Akv * Bkv;

                label4.Text = "Perimetur: " + perimeturPv.ToString();
                label5.Text = "Lice:" + licePv.ToString();
            }
            if (rbTriugulnik.Checked)
            {
                double perimeturTr = Akv + Bkv + Ckv;
                double liceTr = (Akv * Bkv)/2;

                label4.Text = "Perimetur: " + perimeturTr.ToString();
                label5.Text = "Lice: " + liceTr.ToString();
            }
        }
    }
}
