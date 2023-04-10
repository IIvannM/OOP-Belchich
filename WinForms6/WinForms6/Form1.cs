using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms6
{
    public partial class Form1 : Form
    {
        int[] Array = new int[15];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();

            for (int i = 0; i < 15; i++)
            {
                Array[i] = rand.Next(-10,50);
                listBox1.Items.Add("Array[" + i.ToString() + "] = " + Array[i].ToString());
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                int item = Array[i];
                if (item <= 0)
                {
                    break;
                }
                sum += item;
            }
            textBox1.Text = sum.ToString();
        }
    }
}
