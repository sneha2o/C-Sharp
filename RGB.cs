using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apply_color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label4.Text = Convert.ToString(r);
            label5.Text = Convert.ToString(g);
            label6.Text = Convert.ToString(b);
            pictureBox1.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = pictureBox1.BackColor;
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label4.Text = Convert.ToString(r);
            label5.Text = Convert.ToString(g);
            label6.Text = Convert.ToString(b);
            pictureBox1.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;
            label4.Text = Convert.ToString(r);
            label5.Text = Convert.ToString(g);
            label6.Text = Convert.ToString(b);
            pictureBox1.BackColor = Color.FromArgb(255, r, g, b);



        }
    }
}
