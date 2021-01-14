using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Calculator : Form
    {
        double first, second, answer;
        string function;
        Class1 head;
        Class1 current;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            head = new Class1();
            current = head;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 9;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(display.Text, out first))
            {
                function = "+";
                //AddtoList(first, "+");
                //PrintList();
                allofit.Text = display.Text + function;
                //current.number = first;
                //current.n = true;
                //current.s = false;
                //current = current.next;
                //current = new Class1();
                //current.symbol = "+";
                //current.s = true;
                //current.n = false;
                //current = current.next;
                //current = new Class1();
                display.Clear();
            }
            else
            {
                display.Text = "ERROR";
            }
        }

        private void subbtn_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(display.Text, out first))
            {
                function = "-";
                //AddtoList(first, "-");
                //PrintList();
                allofit.Text = display.Text + function;
                display.Clear();
            }
            else
            {
                display.Text = "ERROR";
            }
        }

        private void multbtn_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(display.Text, out first))
            {
                function = "*";
                allofit.Text = display.Text + function;
                //AddtoList(first, "*");
                display.Clear();
            }
            else
            {
                display.Text = "ERROR";
            }
        }

        private void divbtn_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(display.Text, out first))
            {
                function = "/";
                allofit.Text = display.Text + function;
                //AddtoList(first, "/");
                //PrintList();
                display.Clear();
            }
            else
            {
                display.Text = "ERROR";
            }

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void clearallbtn_Click(object sender, EventArgs e)
        {
            display.Clear();
            first = second = answer = 0;
            allofit.Text = "";
            function = "";
        }

        private void solvebtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(display.Text, out second))
            {
                if (function == "+")
                {
                    answer = first + second;
                }
                else if (function == "-")
                {
                    answer = first - second;
                }
                else if (function == "*")
                {
                    answer = first * second;
                }
                else if (function == "/")
                {
                    answer = first / second;
                }
                else
                {
                    display.Text = "ERROR";
                }
                display.Text = "" + answer;
                allofit.Text = allofit.Text + second + "=";
            }
            else
            {
                display.Text = "ERROR";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + 0;
        }

        private void decbtn_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }


        private void AddtoList(double x, string s)
        {
            current.number = x;
            current.n = true;
            current.s = false;
            current = current.next;
            current = new Class1();
            current.symbol = "s";
            current.s = true;
            current.n = false;
            current = current.next;
            current = new Class1();
        }

        private void PrintList()
        {
            Class1 print = head;
            string temp = "";
            do
            {
                if (print.n)
                {
                    temp = temp + print.number;
                }
                else
                {
                    temp = temp + print.symbol;
                }
                print = print.next;
            } while (print != current);
        }

    }
}
