using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillRectangle(blackBrush, 60, 70, 120, 120);

            SolidBrush brushLY = new SolidBrush(Color.LightYellow);
            g.FillRectangle(brushLY, 100, 110, 40, 40);

            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(brownBrush, 300, 300, 20, 30);

            SolidBrush brushG = new SolidBrush(Color.Green);
            g.FillEllipse(brushG, 230, 75, 40, 40);

            Pen f = new Pen(Color.Red, 3);
            f.DashStyle = DashStyle.Dash;
            g.DrawEllipse(f, 300, 20, 50, 50);

            SolidBrush brushY = new SolidBrush(Color.Yellow);
            g.FillEllipse(brushY, 300, 20, 50, 50);


            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            e.Graphics.DrawLine(pen, 120, 110, 120, 150);
            e.Graphics.DrawLine(pen, 120, 130, 140, 130);
            Point point1 = new Point(50, 70);
            Point point2 = new Point(120, 20);
            Point point3 = new Point(190, 70);
            Point[] curvePoints = { point1, point2, point3 };
            e.Graphics.FillPolygon(blackBrush, curvePoints);
        }

    }
    
}

