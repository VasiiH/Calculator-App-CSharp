using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {

        double firstNumber;
        String operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }


        private void n3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }


        private void n4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }


        private void n5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }


        private void n6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }


        private void n7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }



        private void n8_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }


        private void n9_Click_1(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void bdot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void badd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void bmul_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }

        private void bc_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "0";
        }

        private void bequal_Click(object sender, EventArgs e)
        {
           
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(textBox1.Text);
            i:
            if(operation == "+")
            {
                result = firstNumber + secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if(secondNumber == 0)
                {
                    textBox1.Text = "Invalid Input";
                
                    
                }
                else
                {
                    result = firstNumber / secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                
            }
        }
    }
}
