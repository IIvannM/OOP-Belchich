using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms3
{
    public partial class Form1 : Form
    {
        double x;
        double F;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение Y 
            textBox1.Text = "0";
            // Начальное значение Z 
            textBox2.Text = "0";
            // Начальное значение X 
            textBox3.Text = "0";
            button1.Visible = false;
            button2.Visible = false;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            x = double.Parse(textBox3.Text);
            F = Math.Sin(x);
            button1.Visible = true;
            button2.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = double.Parse(textBox3.Text);
            F = x*x;
            button1.Visible = true;
            button2.Visible = true;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = double.Parse(textBox3.Text);
            F = Math.Pow(Math.E, x);
            button1.Visible = true;
            button2.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            // Считывание значения X 
            x = double.Parse(textBox3.Text);
            // Вывод значения X в окно 
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            // Считывание значения Y 
            double y = double.Parse(textBox1.Text);
            // Вывод значения Y в окно 
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            // Считывание значения Z 
            double z = double.Parse(textBox2.Text);
            // Вывод значения Z в окно 
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            textBox4.Text += Environment.NewLine + "F = " + F.ToString();

            // Вычисляем арифметическое выражение 
            double a = Math.Min(F + y, y - z);
            double b = Math.Max(F,y);
            double n = a / b;
            /*double с =  Math.Pow(2,Math.Pow(y,x)) + Math.Pow(Math.Pow(3,x),y) - 
                (y * Math.Atan(z-Math.PI/6)) / ( Math.Abs(x) + 1 / ((y*y)+1) );*/

            // Выводим результат в окно 
            textBox4.Text += Environment.NewLine + "Результат: n = " + n.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
        

        
    }
}
