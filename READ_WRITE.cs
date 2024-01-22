using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Write
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new
                System.IO.FileStream("C:\\Users\\sneha\\source\\repos\\Write\\Write\\Sem4\\myfile.txt", System.IO.FileMode.OpenOrCreate);
            System.IO.StreamWriter sw = new
                System.IO.StreamWriter(fs);
            sw.Write(textBox1.Text);
            MessageBox.Show("Data is Written to the file Successfully:","Info:");
            sw.Close();
            fs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new
                System.IO.FileStream("C:\\Users\\sneha\\source\\repos\\Write\\Write\\Sem4\\myfile.txt", System.IO.FileMode.OpenOrCreate);
            System.IO.StreamReader sr = new
                System.IO.StreamReader(fs);
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }
    }
}
