using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result = 0;
        string operation = "";
        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                double v = double.Parse(txtDisplay.Text);
                result = v;
                operation = "+";
                txtDisplay.Clear();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                result = double.Parse(txtDisplay.Text);
                operation = "-";
                txtDisplay.Clear();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                result = double.Parse(txtDisplay.Text);
                operation = "*";
                txtDisplay.Clear();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                result = double.Parse(txtDisplay.Text);
                operation = "/";
                txtDisplay.Clear();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "") return;

if (operation == "+")
{
    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
}
else if (operation == "-")
{
    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
}
else if (operation == "*")
{
    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
}
else if (operation == "/")
{
    if (txtDisplay.Text == "0")
        txtDisplay.Text = "Error";
    else
        txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
}
        }

        private void button34_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}