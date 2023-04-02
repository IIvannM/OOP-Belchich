using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Объявление переменных, кистей и массивов
        int rotate = 0, movement = 0;
        int xPos;
        int y, y1;
        bool startButton = false;
        int j = 0;
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush lightGrayBrush = new SolidBrush(Color.LightGray);
        SolidBrush orangeBrush = new SolidBrush(Color.OrangeRed);
        SolidBrush groundBrush = new SolidBrush(Color.Gray);

        Point[] rocketPoint = new Point[4];
        Point[] L = new Point[7];

        private void button1_Click(object sender, EventArgs e)
        {
            startButton = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Если нажата кнопка, ракета взлетает
            if (startButton == true)
            {
                if (j % 2 != 0)
                {
                    y1 += 3;
                    xPos -= 1;
                }
                else
                    y1 -= 3;
                j++;
                y1 -= 3;
                y -= 3;
                if (j % 15 == 0)
                    rotate += 1;
                if (j % 30 == 0)
                    movement += 1;

            }
            Invalidate();
        }
        //Присвоим значения переменным при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            y = 350;
            xPos = 160;
            y1 = 386;
        }
        //Обозначим нажатие кнопки
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Если нажата кнопка, появляется пламя
            if (startButton == true)
            {
                L[0] = new Point(xPos + 15, y1);
                L[1] = new Point(xPos + 10, y1 + 25);
                L[2] = new Point(xPos + 15, y1 + 20);
                L[3] = new Point(xPos + 20, y1 + 35);
                L[4] = new Point(xPos + 25, y1 + 20);
                L[5] = new Point(xPos + 30, y1 + 25);
                L[6] = new Point(xPos + 25, y1);
                g.FillPolygon(orangeBrush, L);
            }
            //Отрисовка ракеты
            rocketPoint[0] = new Point(xPos - rotate + 20, y);
            rocketPoint[1] = new Point(xPos, y + 50);
            rocketPoint[2] = new Point(xPos + 20, y + 40);
            rocketPoint[3] = new Point(xPos + 40, y + 50);
            g.FillRectangle(groundBrush,0,400,1000,600);
            g.FillPolygon(lightGrayBrush, rocketPoint);
            g.FillEllipse(blueBrush, xPos + 16 - movement, y + 15, 8, 8);
            g.FillEllipse(blueBrush, xPos + 16 - movement, y + 25, 8, 8);

        }

    }

}
