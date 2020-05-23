using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenaralCalculator;
namespace GenaralCalculator
{
      
    public partial class GenaralCalculator : Form
    {
        String extra;
        Double firstNumber;
        String operation;

        public GenaralCalculator()
        {
            InitializeComponent();
        }
        private void numClick(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "0")
            {
                textBox1.Text = ((Button)sender).Text;
            }
            else
            {
                textBox1.Text = textBox1.Text + ((Button)sender).Text;
            }
        }


        private void button_equal_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double secoundNumber = double.Parse(s);
            double result;

            if (operation == "+")
            {
                result = firstNumber + secoundNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
                TextBox2.Text = extra + secoundNumber + "=" + firstNumber;
            }

            else if (operation == "-")
            {
                result = firstNumber - secoundNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
                TextBox2.Text = extra + secoundNumber + "=" + firstNumber;
            }

            else if (operation == "×")
            {
                result = firstNumber * secoundNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
                TextBox2.Text = extra + secoundNumber + "=" + firstNumber;
            }

            else if (operation == "÷")
            {
                if (secoundNumber == 0)
                {
                    TextBox2.Text = "Invalid Number";
                }
                else
                {
                    result = firstNumber / secoundNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                    TextBox2.Text = extra + secoundNumber + "=" + firstNumber;
                }
            }

            else if (operation == "%")
            {
                result = (firstNumber * secoundNumber) / 100;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
                TextBox2.Text = extra + secoundNumber + "=" + firstNumber;
            }

        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
            TextBox2.Text = firstNumber + "+";
            extra = TextBox2.Text;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
            TextBox2.Text = firstNumber + "-";
            extra = TextBox2.Text;
           
        }

        private void button_multiapply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "×";
            TextBox2.Text = firstNumber + "*";
            extra = TextBox2.Text;
  
        }

        private void button_divition_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "÷";
            TextBox2.Text = firstNumber + "/";
            extra = TextBox2.Text;
        
        }

        private void button_persent_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "%";
            Double extra1 = firstNumber / 100;
            TextBox2.Text = firstNumber + operation +"="+ extra1;
            extra =firstNumber + operation;

        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            double result = System.Math.Sqrt(firstNumber);    
            textBox1.Text = Convert.ToString(result);
            TextBox2.Text = ((Button)sender).Text + firstNumber + "="+ textBox1.Text;
            firstNumber = result;
           
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            TextBox2.Text = "";
            firstNumber = 0;
            operation = null;

        }
   
        private void Off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Scientific_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Calculator sc = new Calculator();
            sc.ShowDialog();
        }
    }
}
