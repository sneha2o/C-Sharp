using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rohit");
            listBox1.Items.Add("Dhawan");
            listBox1.Items.Add("Rahul");
            listBox1.Items.Add("Pant");
            listBox1.Items.Add("Kohali");
            listBox1.Items.Add("Dhoni");
            listBox1.Items.Add("Jadeja");
            listBox1.Items.Add("Chahal");
            listBox1.Items.Add("Bumarah");
            listBox1.Items.Add("Shami");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
                MessageBox.Show("Select any one item in the listbox1 and then click in this button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox1.SelectedItems.Count;
            for(i=0;i<n;i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[0]);
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox1.Items.Count;
            for (i = 0; i < n; i++)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                listBox1.Items.Remove(listBox1.Items[0]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
                MessageBox.Show("Select any one item in the listbox2 and then click in this button");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox2.SelectedItems.Count;
            for (i = 0; i < n; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox2.Items.Count;
            for (i = 0; i < n; i++)
            {
                listBox1.Items.Add(listBox2.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
            }

        }
    }
}
