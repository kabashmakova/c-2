﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (
                    str[i] == '.' ||
                    str[i] == ',' ||
                    str[i] == ';' ||
                    str[i] == ':' ||
                    str[i] == '?' ||
                    str[i] == '!' ||
                    str[i] == '"' ||
                    str[i] == '-' ||
                    str[i] == '(' ||
                    str[i] == ')'
                    ) count++;
       
                i++;
            }
            label1.Text = "Количество знаков препинания = " + count.ToString();
        }
    }
}
