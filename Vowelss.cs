using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vowels = 0, spaces = 0, digits = 0, spsymbols = 0, consonant = 0;
            int i;
            for (i = 0; i < textBox1.Text.Length; i++)
            {
                char ch = char.ToLower(textBox1.Text[i]);
                if (char.IsDigit(ch))
                    digits++;
                else if (ch == ' ')
                    spaces++;
                else if (!char.IsLetterOrDigit(ch))
                    spsymbols++;
                else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonant++;
            }
            String str = "There are \n" + vowels + "-vowels\n" + digits + "-Digits\n" + spaces + "-Spaces\n" + spsymbols + "-Special Symbols\n Found in this Text";
            MessageBox.Show(str);
        
        }
    }
}
