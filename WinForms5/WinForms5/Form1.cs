using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms5
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


        private List<Panel> panels = new List<Panel>();
        private int i = 0;
        private int x = 10;
        private int y = 10;

        private void button1_Click(object sender, EventArgs e)
        {
            Panel newPanel = new Panel();
            newPanel.BackColor = ColorTranslator.FromHtml("#ECF7FF");
            if (i == 5)
            {
                x += 220;
                y = 10;
                i = 0;
            }
            newPanel.Location = new Point(x, y);
            newPanel.Size = new Size(200, 50);
            this.Controls.Add(newPanel);
            panels.Add(newPanel);
            y += 80;
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in panels)
            {
                // Проветяет, есть ли текстбокс в панеле
                bool hasInputField = panel.Controls.OfType<TextBox>().Any();

                // Добавляет, если его нет
                if (!hasInputField)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Location = new Point(10, panel.Controls.Count * 25);
                    newTextBox.Size = new Size(100, 20);
                    panel.Controls.Add(newTextBox);
                }
            }
        }



    }
}


