using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Lab_Prac_1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string input = userInputTextBox.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a valid expression.");
                return;
            }

            string[] numbers;
            char operation;

            if (input.Contains('+'))
            {
                numbers = input.Split('+');
                operation = '+';
            }
            else if (input.Contains('-'))
            {
                numbers = input.Split('-');
                operation = '-';
            }
            else if (input.Contains('*'))
            {
                numbers = input.Split('*');
                operation = '*';
            }
            else if (input.Contains('/'))
            {
                numbers = input.Split('/');
                operation = '/';
            }
            else if (input.Contains('^'))
            {
                numbers = input.Split('^');
                operation = '^';
            }
            else
            {
                MessageBox.Show("Invalid operation. Please use '+', '-', '*', '/', or '^'.");
                return;
            }

            if (numbers.Length != 2 || !double.TryParse(numbers[0], out double num1) || !double.TryParse(numbers[1], out double num2))
            {
                MessageBox.Show("Invalid expression.");
                return;
            }

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                case '^':
                    result = Math.Pow(num1, num2);
                    break;
            }

            resultLabel.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
