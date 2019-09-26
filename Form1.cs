using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c;
            switch (textBox3.Text)
            {
                case "+":
                    {
                        c = a + b;
                        label1.Text = c.ToString();
                        break;
                    }
                case "-":
                    {
                        c = a - b;
                        label1.Text = c.ToString();
                        break;
                    }
                case "*":
                    {
                        c = a * b;
                        label1.Text = c.ToString();
                        break;
                    }
                case "/":
                    {
                        c = a / b;
                        label1.Text = c.ToString();
                        break;
                    }
                default:
                    MessageBox.Show(" ERROR ");
                    break;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1" :
                    label1.Text = "понедельник";
                    break;
                case "2":
                    label1.Text = "вторник";
                    break;
                case "3":
                    label1.Text = "среда";
                    break;
                case "4":
                    label1.Text = "четверг";
                    break;
                case "5":
                    label1.Text = "пятница";
                    break;
                case "6":
                    label1.Text = "суббота";
                    break;
                case "7":
                    label1.Text = "воскресенье";
                    break;
                default:
                   MessageBox.Show(" ERROR ");
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    label1.Text = "январь";
                    break;
                case "2":
                    label1.Text = "февраль";
                    break;
                case "3":
                    label1.Text = "март";
                    break;
                case "4":
                    label1.Text = "апрель";
                    break;
                case "5":
                    label1.Text = "май";
                    break;
                case "6":
                    label1.Text = "июнь";
                    break;
                case "7":
                    label1.Text = "июль";
                    break;
                case "8":
                    label1.Text = "август";
                    break;
                case "9":
                    label1.Text = "сентябрь";
                    break;
                case "10":
                    label1.Text = "октябрь";
                    break;
                case "11":
                    label1.Text = "ноябрь";
                    break;
                case "12":
                    label1.Text = "декабрь";
                    break;
                default:
                    MessageBox.Show(" ERROR ");
                    break;
            }
        }
    }
}
