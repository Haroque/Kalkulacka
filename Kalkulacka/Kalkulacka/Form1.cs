using System;
using System.Windows.Forms;

namespace Kalkulacka
{
    public partial class Kalkulacka_teror : Form
    {
        private double op = 0.0;
        private string tedop = "";

        public Kalkulacka_teror()
        {
              InitializeComponent();
            { 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            op = 0.0;
            tedop = "";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double op2 = double.Parse(textBox1.Text);
            double vysledek = 0.0;

            switch (tedop)
            {
                case "/":
                    vysledek = op / op2;
                    break;

                case "-":
                    vysledek = op - op2;
                    break;
                
                case "+":
                    vysledek = op + op2;
                    break;

                case "*":
                    vysledek = op * op2;
                    break;

                
            }

            textBox1.Text = vysledek.ToString();
            op = vysledek;
            tedop = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            tedop = "*";
            op = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            tedop = "+";
            op = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            tedop = "/";
            op = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            tedop = "-";
            op = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        

        

        private void teror_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
