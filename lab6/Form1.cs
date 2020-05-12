using System;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        float first, second;
        int number;
        string temp;
        public Form1()
        {
            InitializeComponent();
            this.KeyUp += new KeyEventHandler(textBox1_KeyDown);
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue>=48 && e.KeyValue <=57)
                textBox1.Text += (e.KeyValue-48);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            number = 1;
            temp = textBox1.Text;
            textBox1.Text += "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            number = 2;
            temp = textBox1.Text;
            textBox1.Text += "-";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            number = 3;
            temp = textBox1.Text;
            textBox1.Text += "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first = float.Parse(textBox1.Text);
            number = 4;
            temp = textBox1.Text;
            textBox1.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculate()
        {
            switch (number)
            {
                case 1:
                    try
                    {
                        second = first + float.Parse(textBox1.Text.Substring(textBox1.Text.Length - 1));
                    }
                    catch(FormatException)
                    {
                        textBox1.Text = "Неверное выражение";
                        break;
                    }
                    textBox1.Text = second.ToString();
                    Clipboard.SetData(DataFormats.Text, (Object)second.ToString());
                    break;
                case 2:
                    try
                    {
                        second = first - float.Parse(textBox1.Text.Substring(textBox1.Text.Length - 1));
                    }
                    catch (FormatException)
                    {
                        textBox1.Text = "Неверное выражение";
                        break;
                    }
                    textBox1.Text = second.ToString();
                    Clipboard.SetData(DataFormats.Text, (Object)second.ToString());
                    break;
                case 3:
                    try
                    {
                        second = first * float.Parse(textBox1.Text.Substring(textBox1.Text.Length - 1));
                    }
                    catch (FormatException)
                    {
                        textBox1.Text = "Неверное выражение";
                        break;
                    }
                    textBox1.Text = second.ToString();
                    Clipboard.SetData(DataFormats.Text, (Object)second.ToString());
                    break;
                case 4:
                    if (float.Parse(temp)==0)
                    {
                        textBox1.Text = "Ошибка";
                        break;
                    }
                    try
                    {
                        second = first / float.Parse(textBox1.Text.Substring(textBox1.Text.Length - 1));
                    }
                    catch (FormatException)
                    {
                        textBox1.Text = "Неверное выражение";
                        break;
                    }
                    textBox1.Text = second.ToString();
                    Clipboard.SetData(DataFormats.Text, (Object)second.ToString());
                    break;

                default:
                    break;
            }

        }
    }
}
