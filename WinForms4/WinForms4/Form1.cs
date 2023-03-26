using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);

            // Цикл для табулирования функции 
            double x = x0;
            while (x <= xk)
            {
                double y = 9 * (Math.Pow(x, 3) + Math.Pow(b , 3)) * Math.Tan(x * Math.PI/180);
                textBox5.Text += "x=" + Convert.ToString(x) + ";    y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
