using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ok2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public char[] bukovka = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToLower();
            int key = Convert.ToInt32(textBox2.Text);
            if (key != 0)
            {
                foreach (char c in str)
                {
                    if (c != ' ')
                    {
                        for (int i = 0; i < bukovka.Length; i++)
                        {
                            if(c == bukovka[i])
                            {
                                int j = (i + key) % 26;
                                textBox3.Text += bukovka[j];
                            }
                        }
                    }
                    else
                    {
                        textBox3.Text += ' ';
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "3";
            textBox3.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

