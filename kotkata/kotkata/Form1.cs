using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kotkata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Image Files(*.JPG;*.GIF)|*.JPG;*.GIF| All files (*.*)|*.*
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zdrasti"+textBox1.Text+"!!! \nTova e golqmoto postijenie");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && (saveFileDialog1.FileName.Length > 0))
            {
                try
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
                catch (Exception) { }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = "1. " + textBox1.Text.Trim()+" Komentar:"+richTextBox1.Text.Trim();
            Form2 secondform = new Form2(str);
            secondform.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = "1. "  + " Komentar:" ;
            Form2 secondform = new Form2(str);
            secondform.ShowDialog();
        }
    }
}
