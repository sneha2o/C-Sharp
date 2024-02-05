using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formsmdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void form2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form3 frm = new Form3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = this.ActiveMdiChild;
            frm.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openToolStripMenuItem.Checked = true;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
