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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string str2 = "";
            string str3 = "";
            int len = str.Length;
            for (int i = 0; i < len; i++)
            {
                if (str[i] == ' ') continue;
                else str2 += str[i];
            }
            for (int i = len - 1; i >= 0; i--)
            {
                if (str[i] == ' ') continue;
                else str3 += str[i];
            }
            if (str2 == str3)
            {
                label1.Text = "Это палиндром!";
                str2 = "";
            }
            else
            {
                label1.Text = "Это не палиндром!";
                str3 = "";
            }
        }
    }
}
