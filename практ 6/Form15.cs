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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arr = ("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            string str2 = "";
            int len = str.Length;
            bool flag = false;
            for (int i = 0; i < len; i++)
            {

                for(int j = 0; j < arr.Length; j++)
                {
                    if (str[i] == arr[j])
                    {
                        str2 += "+";
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    str2 += str[i];
                }
                else
                {
                    flag = false;
                }
            }
            listBox1.Items.Add(str2);
        }
    }
}
