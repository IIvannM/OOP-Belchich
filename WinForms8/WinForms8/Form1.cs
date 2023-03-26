using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxXmin.Text == "" || textBoxXmax.Text == "" || textBoxXstep.Text == "")
                MessageBox.Show("Заполните все поля!");
            else
            { 
                double x0 = 1;
                double xK = 2.2;
                double dX = 0.2;
                double b = 3.2;
                // Количество точек графика 
                int count = (int)Math.Ceiling((xK - x0) / dX);
                // Массив значений X – общий для обоих графиков 
                double[] x = new double[count];
                // Два массива Y – по одному для каждого графика 
                double[] y = new double[count];
                for (int i = 0; i < count; i++)
                {
                    x[i] = x0 + dX * i; //Вычисляем значение Х
                    y[i] = 9 * (Math.Pow(x[i], 3) + Math.Pow(b, 3)) * Math.Tan(x[i] * Math.PI / 180);
                }
                // Настраиваем оси графика
                chart1.ChartAreas[0].AxisX.Minimum = x0;
                chart1.ChartAreas[0].AxisX2.Maximum = xK;
                //Определяем шаг сетки
                chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dX;
                //Добавляем вычислительные значения в графики
                chart1.Series[0].Points.DataBindXY(x, y);

                // Считываем с формы требуемые значения 
                double xMin = double.Parse(textBoxXmin.Text);
                double xMax = double.Parse(textBoxXmax.Text);
                double xStep = double.Parse(textBoxXstep.Text);
                // Количество точек графика 
                count = (int)Math.Ceiling((xMax - xMin) / xStep) + 1;
                // Массив значений X – общий для обоих графиков 
                double[] x2 = new double[count];
                double[] y2 = new double[count];
                for (int i = 0; i < count; i++)
                {
                    x2[i] = xMin + xStep * i; //Вычисляем значение Х
                    y2[i] = Math.Pow(x2[i], 2) + Math.Sin(x2[i]);
                }
                // Настраиваем оси графика
                if (xMin < x0)                                                  //если есть необходимость, увеличиваем оси
                    chart1.ChartAreas[0].AxisX.Minimum = xMin;
                if(xMax > xK)
                    chart1.ChartAreas[0].AxisX2.Maximum = xMax;
                //Добавляем вычислительные значения в графики
                chart1.Series[1].Points.DataBindXY(x2, y2);
            }       
        }

        /*private void button3_Click(object sender, EventArgs e) 
        {
            chart1.Series.Clear();
            // Считываем с формы требуемые значения 
            double xMin = double.Parse(textBoxXmin.Text);
            double xMax = double.Parse(textBoxXmax.Text);
            double xStep = double.Parse(textBoxXstep.Text);
            // Количество точек графика 
            int count = (int)Math.Ceiling((xMax - xMin) / xStep) + 1;
            // Массив значений X – общий для обоих графиков 
            double[] x2 = new double[count];
            double[] y2 = new double[count];
            for (int i = 0; i < count; i++)
            {
                x2[i] = xMin + xStep * i; //Вычисляем значение Х
                y2[i] = Math.Pow(x2[i],2) + Math.Sin(x2[i]);
            }
            // Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = xMin;
            chart1.ChartAreas[0].AxisX2.Maximum = xMax;
            //Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = xStep;
            //Добавляем вычислительные значения в графики
            chart1.Series[0].Points.DataBindXY(x2, y2);
        }*/
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
