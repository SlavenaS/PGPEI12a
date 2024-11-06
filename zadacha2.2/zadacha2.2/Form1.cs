using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            openFileDialog2.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Greshka");
                }
            }
        }

        void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            //izbira i poluchava izbraniq fail
            string filename = openFileDialog2.FileName;
            //prochita faila v tekstovata kutiq
            string filetext = System.IO.File.ReadAllText(filename);
            textBox1.Text = filetext;
            MessageBox.Show("File is found");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //izbira i poluchava izbraniq fail
            string filename = saveFileDialog1.FileName;
            //prochita faila v tekstovata kutiq
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("File is saved");
        }
    }
}
