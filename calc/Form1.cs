using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        string flag;
        int chislo1;
        int chislo2;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //нуль
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text = textBox1.Text+0;
            }
            else
            {
               textBox1.Text = textBox1.Text + 0;
            }
            
        }

        //один
        private void button22_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
                
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }
        }

        //три
        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";

            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }
        }


        //ТРОЕЧКА
        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";

            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }
        }

        //чотири
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";

            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }
        }

        //п'ять
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";

            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }
        }

        //шість
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";

            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }
        }

        //сім
        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";

            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }
        }

        //вісім
        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";

            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }
        }

        //дев'ять
        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";

            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }
        }

        //плюс
        private void button28_Click(object sender, EventArgs e)
        {
            flag = "+";
            chislo1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            
            
        }

        //мінус
        private void button25_Click(object sender, EventArgs e)
        {
            flag = "-";
            chislo1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }
        //множення
        private void button20_Click(object sender, EventArgs e)
        {
            flag = "*";
            chislo1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
        }
        //одно  
        private void button26_Click(object sender, EventArgs e)
        {
            if (flag =="+")
            {
                chislo2 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = chislo1 + chislo2+"";
            }
            if (flag == "-")
            {
                chislo2 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = chislo1 - chislo2 + "";
            }
            if (flag == "*")
            {
                chislo2 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = chislo1 * chislo2 + "";
            }
        }

       
    }
}
