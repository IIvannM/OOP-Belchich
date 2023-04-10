using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms7
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
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            int[,] a = new int[15, 15];
            int i, j, minPositiveCount = 15, colIndex = 0;
            Random rand = new Random();

            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }

            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    dataGridView1.Columns[j].Width = 35;
                }
            }

            for (j = 0; j < 15; j++)
            {
                int positiveCount = 0;
                for (i = 0; i < 15; i++)
                {
                    if (a[i, j] > 0)
                    {
                        positiveCount++;
                    }
                }
                if (positiveCount < minPositiveCount)
                {
                    minPositiveCount = positiveCount;
                    colIndex = j;
                }
            }

            if (minPositiveCount == 0)
            {
                textBox1.Text = "Все столбцы без положительных элементов.";
            }
            else
            {
                textBox1.Text = Convert.ToString(colIndex + 1);
            }
        }
    }
}
