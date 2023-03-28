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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            SolidBrush bgEllipseBrash = new SolidBrush(ColorTranslator.FromHtml("#65C694"));
            g.FillEllipse(bgEllipseBrash,-450, 150, 1500, 500);

            SolidBrush bgEllipseBrash2 = new SolidBrush(ColorTranslator.FromHtml("#55AD80"));
            g.FillEllipse(bgEllipseBrash2, -450, 350, 1500, 500);


            SolidBrush blackBrush = new SolidBrush(Color.Black);
            g.FillRectangle(blackBrush, 60, 70, 120, 120);

            SolidBrush brushLY = new SolidBrush(Color.LightYellow);
            g.FillRectangle(brushLY, 100, 110, 40, 40);

            SolidBrush brushGreen = new SolidBrush(Color.Green);
            g.FillRectangle(brushLY, 100, 110, 40, 40);

            SolidBrush brownBrush = new SolidBrush(Color.Brown);
            g.FillRectangle(brownBrush, 300, 300, 20, 30);

            SolidBrush brushG = new SolidBrush(Color.Green);
          
            Pen f = new Pen(Color.Red, 3);
            f.DashStyle = DashStyle.Dash;
            g.DrawEllipse(f, 700, 20, 70, 70);

            SolidBrush brushY = new SolidBrush(Color.Yellow);
            g.FillEllipse(brushY, 700, 20, 70, 70);


            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
            e.Graphics.DrawLine(pen, 120, 110, 120, 150);
            e.Graphics.DrawLine(pen, 120, 130, 140, 130);
            Point point1 = new Point(50, 70);
            Point point2 = new Point(120, 20);
            Point point3 = new Point(190, 70);
            Point[] curvePoints = { point1, 
                point2, 
                point3 };
            e.Graphics.FillPolygon(blackBrush, curvePoints);
            // Create pen.
            Pen greenPen = new Pen(Color.Green, 3);
            // Draw polygon to screen.
            Point point4 = new Point(260, 300);
            Point point5 = new Point(310, 140);
            Point point6 = new Point(360, 300);
            Point[] curvePoints2 = { point4,
                point5,
                point6 };
            e.Graphics.FillPolygon(brushGreen, curvePoints2);
            // Draw retangle to screen.
            Pen brownPen = new Pen(Color.Brown, 3);
            g.DrawRectangle(brownPen, 500, 400, 20, 30);
            // Draw polygon to screen.
            Point point7 = new Point(460, 400);
            Point point8 = new Point(510, 240);
            Point point9 = new Point(560, 400);
            Point[] curvePoints3 = { point7,
                point8,
                point9 };
            e.Graphics.DrawPolygon(greenPen, curvePoints3);

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            Text = string.Format("Координаты: {0};{1}", e.X, e.Y);
        }
    }
    
}

