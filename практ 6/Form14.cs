using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практ_6
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char b1 = Convert.ToChar(textBox1.Text);
            char b2 = Convert.ToChar(textBox2.Text);
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string str2="";
            int len = str.Length;
            for (int i = 0;i< len; i++)
            {
                if (str[i] != b1 && str[i] != b2)
                {
                    str2 += str[i];
                }
                else if(str[i]==b1)
                {
                    str2 += b2;
                }
                else if (str[i] == b2)
                {
                    str2 += b1;
                }
            }
            listBox1.Items.Add(str2);
        }
    }
}
