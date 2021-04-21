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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string str2 = "";
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == 'А')
                {
                    str2 += '*';
                }
                else
                {
                    str2 += str[i];
                }
            }
            listBox1.Items.Add(str2);
        }
    }
}
