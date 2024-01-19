using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_Click
{
    public partial class Form1 : Form
    {
        int pos;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (chkMatchCase.Checked == true)
                pos = Editor.Find(txtFind.Text, 0, Editor.Text.Length - 1, RichTextBoxFinds.MatchCase);
            else
                pos = Editor.Find(txtFind.Text, 0, Editor.Text.Length - 1, RichTextBoxFinds.WholeWord);
            if (pos >= 0)
                Editor.Select(pos, txtFind.Text.Length);
            Editor.SelectionColor = Color.Red;
            Editor.SelectionBackColor = Color.Yellow;
           

        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            if (chkMatchCase.Checked == true)
                pos = Editor.Find(txtFind.Text, pos+1, Editor.Text.Length - 1, RichTextBoxFinds.MatchCase);
            else
                pos = Editor.Find(txtFind.Text, pos+1, Editor.Text.Length - 1, RichTextBoxFinds.WholeWord);
            if (pos >= 0)
                Editor.Select(pos, txtFind.Text.Length);
            else
                MessageBox.Show("The text you are looking for is not Found:", "Error!!!");

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Editor.SelectedText = txtReplace.Text;
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            pos = 0;
            cmdFind.PerformClick();
            if(pos!=-1)
            {
                cmdReplace.PerformClick();
                while(pos!=-1)
                {
                    cmdFindNext.PerformClick();
                }
            }
        }
    }
}
