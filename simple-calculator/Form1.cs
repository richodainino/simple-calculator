using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        bool firstInput = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }
        private void num0_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
            firstInput = true;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            if (firstInput)
            {
                first = userInput;
                firstInput = false;
            }
            else
            {
                first = result.ToString();
            }
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            if (firstInput)
            {
                first = userInput;
                firstInput = false;
            }
            else
            {
                first = result.ToString();
            }
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            if (firstInput)
            {
                first = userInput;
                firstInput = false;
            }
            else
            {
                first = result.ToString();
            }
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            if (firstInput)
            {
                first = userInput;
                firstInput = false;
            }
            else
            {
                first = result.ToString();
            }
            userInput = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (firstInput)
            {
                result = userInput == "" ? 0.0 : Convert.ToDouble(userInput);
                calculatorDisplay.Text = result.ToString();
                return;
            }

            double firstNum, secondNum;
            second = userInput;
            firstNum = first != "" ? Convert.ToDouble(first) : result;
            secondNum = Convert.ToDouble(second);
            // Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            // Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            // Divide
            else if (function == '/')
            {
                if (secondNum == 0.0)
                {
                    calculatorDisplay.Text = "You can't";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
            }
            // Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }
    }
}
