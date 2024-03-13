using System;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace myCalc
{
    public partial class Form1 : Form
    {
        private int dig_counter;
        private bool isFirstDigit;
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
        }

        private void texBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private string Do_calculations(string operation)
        {
            //char lastOperation = s.Last();
            //string operation = s[0..^1];
            //char[] chars = operation.ToCharArray();

            string dec = @"\" + CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            Regex reg = new(@"^-{0,1}(\d+|\d+" + dec + @"\d*|\d*" + dec + @"\d+|[\.\,]){1}[\+\-x\/]{1}(\d+|\d+" + dec + @"\d*|\d*" + dec + @"\d+|[\.\,]){1}$");
            Match match = reg.Match(operation);

            string[] parts = new string[2];
            bool isMinus = false;
            if (match.Success)
            {
                string op = "";
                if (operation[0] == '-')
                {
                    isMinus = true;
                    operation = operation[1..];
                }
                if (operation.Contains("+"))
                {
                    parts = operation.Split("+");
                    op = "+";
                }
                else if (operation.Contains("-"))
                {
                    parts = operation.Split("-");
                    op = "-";
                }
                else if (operation.Contains("x"))
                {
                    parts = operation.Split("x");
                    op = "x";
                }
                else if (operation.Contains("/"))
                {
                    parts = operation.Split("/");
                    op = "/";
                }
                if (isMinus)
                {
                    parts[0] = "-" + parts[0];
                }
                if (parts[0] == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                {
                    parts[0] = "0";
                }
                if (parts[1] == CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                {
                    parts[1] = "0";
                }
                decimal p1 = decimal.Parse(parts[0]);
                decimal p2 = decimal.Parse(parts[1]);
                var result = 0d;
                switch (op)
                {
                    case "+":
                        result = Decimal.ToDouble(p1 + p2);
                        break;
                    case "-":
                        result = Decimal.ToDouble(p1 - p2);
                        break;
                    case "x":
                        result = Decimal.ToDouble(p1 * p2);
                        break;
                    case "/":
                        if (p2 != 0)
                        {
                            result = Decimal.ToDouble(p1 / p2);
                        }
                        else
                        {
                            errorProvider1.SetError(textBox1, "Cannot divide by 0!");
                            result = Decimal.ToDouble(p1);
                        }
                        break;
                }
                string res = result.ToString();
                return res;
            }
            else
            {
                //Regex reg2 = new(@"^[\+\-x\/]{1}\.[\+\-x\/]{1}$");
                //if(textBox1.Text.Contains(reg2))
                //{

                //}
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                isFirstDigit = false;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                errorProvider1.Clear();
                dig_counter = 0;
                if (textBox1.Text != string.Empty)
                {
                    char last = textBox1.Text.Last();
                    if (last == '+' || last == '-' || last == 'x' || last == '/')
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    }

                    if (textBox1.Text.Length > 2)
                    {
                        var fun = Do_calculations(textBox1.Text);
                        if (fun != string.Empty)
                        {
                            textBox1.Text = string.Empty;
                        }
                        textBox1.Text += fun;
                        if (fun.Contains("E"))
                        {
                            errorProvider1.SetError(textBox1, "Number is too big!");
                            button1.Enabled = false;
                            button2.Enabled = false;
                            button3.Enabled = false;
                            button4.Enabled = false;
                            button5.Enabled = false;
                            button6.Enabled = false;
                            button7.Enabled = false;
                            button8.Enabled = false;
                            button9.Enabled = false;
                            button10.Enabled = false;
                            button11.Enabled = false;
                            button12.Enabled = false;
                            button13.Enabled = false;
                            button14.Enabled = false;
                            button15.Enabled = false;
                            button16.Enabled = false;
                        }
                    }

                    textBox1.Text += button.Text;
                    button12.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            errorProvider1.Clear();
            dig_counter = 0;
            isFirstDigit = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (dig_counter == 10)
                {
                    errorProvider1.SetError(textBox1, "Too many digits");
                }
                else
                {
                    textBox1.Text += button.Text;
                    dig_counter++;
                    if (textBox1.Text.Length > 1)
                    {
                        if (textBox1.Text[textBox1.Text.Length - 2] == '0' && button12.Enabled == true && isFirstDigit == false)
                        {
                            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 2, 1);
                            dig_counter--;
                        }
                    }
                    
                    if(button.Text == "0" && isFirstDigit == false)
                    {
                        button16.Enabled = false;
                    }
                    else
                    {
                        button16.Enabled = true;
                        isFirstDigit = true;
                    }
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                isFirstDigit = true;
                textBox1.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                button12.Enabled = false;
                button16.Enabled = true;
                dig_counter = 0;
                errorProvider1.Clear();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var res = Do_calculations(textBox1.Text);
            if (res != string.Empty)
            {
                textBox1.Text = string.Empty;
                if (res[0] == '-')
                {
                    textBox1.Text += res[1..];
                }
                else
                {
                    textBox1.Text += "-" + res;
                }
            }
            else
            {
                string txt = textBox1.Text;
                if (txt != string.Empty)
                {
                    if (txt[0] == '-')
                    {
                        textBox1.Text = textBox1.Text[1..];
                    }
                    else if (textBox1.Text != "0")
                    {
                        textBox1.Text = "-" + textBox1.Text;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isFirstDigit = false;
            string dec = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            errorProvider1.Clear();
            var fun = Do_calculations(textBox1.Text);
            if (fun != string.Empty)
            {
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                textBox1.Text = string.Empty;
                if (double.Parse(fun) >= Math.Pow(10, 18))
                {
                    errorProvider1.SetError(textBox1, "Number is too big!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button13.Enabled = false;
                    button14.Enabled = false;
                    button15.Enabled = false;
                    button16.Enabled = false;
                }
            }
            textBox1.Text += fun;
            string txt = textBox1.Text;
            if (txt.Contains(dec))
            {
                button12.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}