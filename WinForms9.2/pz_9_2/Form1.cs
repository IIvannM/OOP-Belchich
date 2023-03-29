using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pz_9_2
{
    public partial class Form1 : Form
    {
        GraphicsPath path;
        public Form1()
        {
            InitializeComponent();
            path = new GraphicsPath();
        }

        int xpos = 20;
        int ypos = 20;
        int width = 86;
        int height = 116;


        string trajectory = "right";
        bool negativeY = true;
        bool negativeX = false;
        bool moveX = true;
        bool moveY = true;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            switch (trajectory) 
            {
                case "right":
                    if (xpos + width - 16 <= pictureBox1.Width)
                        xpos += 5;
                    else
                        trajectory = "down";
                    break;
                case "down":
                    if (ypos + height <= pictureBox1.Height)
                        ypos += 5;
                    else 
                        trajectory= "left";
                    break;
                case "left":
                    if (xpos >= 25)
                        xpos -= 5;
                    else
                        trajectory = "up";
                    break;
                case "up":
                    if (ypos >= 26)
                        ypos -= 5;
                    else
                        trajectory= "right";
                    break;
            }
            pictureBox1.Invalidate();
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            HatchBrush brush = new HatchBrush(myBrush, figureColor);

            Pen pen1 = new Pen(Color.White, 0);
            g.DrawRectangle(pen1, xpos-20, ypos-20, 88, 116);

            Rectangle rect = new Rectangle(xpos, ypos, 46, 100);
            g.FillRectangle(brush, rect);

            Point point1 = new Point(xpos - 23, ypos + 20);
            Point point2 = new Point(xpos + 23, ypos - 20);
            Point point3 = new Point(xpos + 70, ypos + 20);
            Point[] curvePoints = { point1,
                point2,
                point3 };

            Rectangle triangle = new Rectangle(xpos + 12, ypos + 30, 1, 70);
            g.FillPolygon(brush, curvePoints);

            path.Reset();
            path.StartFigure();
            path.AddEllipse(rect);
            path.CloseFigure();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                if (path.IsVisible(pt))
                {
                    ColorDialog clrDlg = new ColorDialog();
                    if (clrDlg.ShowDialog() == DialogResult.OK)
                        figureColor = clrDlg.Color;
                }
            }
            if (e.Button == MouseButtons.Right)
            {
                Point pt = new Point(e.X, e.Y);
                if (path.IsVisible(pt))
                {
                    Form2 styleDialog = new Form2();
                    if (styleDialog.ShowDialog() == DialogResult.OK)
                        myBrush = styleDialog.Style;
                }
            }
        }

        HatchStyle myBrush;
        Color figureColor;
        private void Form1_Load(object sender, EventArgs e)
        {
            figureColor = Color.Yellow;
            myBrush = HatchStyle.DarkVertical;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
