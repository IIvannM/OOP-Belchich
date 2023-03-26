using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X 
            textBox1.Text = "3,251";
            // Начальное значение Y 
            textBox2.Text = "0,325";
            // Начальное значение Z 
            textBox3.Text = "0,466e-4";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X 
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно 
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            // Считывание значения Y 
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно 
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            // Считывание значения Z 
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно 
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            // Вычисляем арифметическое выражение 
            double a = Math.Pow(2, Math.Pow(y, x)) + Math.Pow(Math.Pow(3, x), y);
            double b = (y * (Math.Atan(z * Math.PI / 180) - Math.PI / 6)) / (Math.Abs(x) + 1 / ((y * y) + 1));
            double c = (a - b);
            /*double с =  Math.Pow(2,Math.Pow(y,x)) + Math.Pow(Math.Pow(3,x),y) - 
                (y * Math.Atan(z-Math.PI/6)) / ( Math.Abs(x) + 1 / ((y*y)+1) );*/

            // Выводим результат в окно 
            textBox4.Text += Environment.NewLine + "Результат: C = " + c.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
