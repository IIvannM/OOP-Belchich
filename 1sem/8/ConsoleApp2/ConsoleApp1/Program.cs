using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)
        {
            this.x = x; this.y = y;
        }
        public Point()
        { }
        public void Show()
        {
            Console.WriteLine("Точка с координатами: ({0}, {1})", x, y);
        }
        public double Dlina(Point p1, Point p2)
        {
            double Dl = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) +
            (p1.y - p2.y) * (p1.y - p2.y));
            return Dl;
        }
        public override string ToString()
        {
            string ss = x + " ; " + y;
            return ss;
        }
    }
    class Line
    {
        private Point pStart = new Point();
        private Point pEnd = new Point();
        public Line(Point pStart, Point pEnd)
        {
            this.pStart = pStart;
            this.pEnd = pEnd;
        }
        public Line()
        { }
        public void Show()
        {
            Console.WriteLine("Отрезок с координатами: ({0}) - ({1})",
            pStart, pEnd);
        }
        public double DlinL()
        {
            return pStart.Dlina(pEnd, pStart);
        }
    }
    class Program
    {
        static void Main()
        {
            Point p1 = new Point();
            p1.Show();
            Point p2 = new Point(12, 13);
            p2.Show();
            Line line = new Line(p1, p2);
            line.Show();
            double dtr = line.DlinL();
            Console.WriteLine("Длина отрезка " + dtr);
            Console.ReadKey();
        }
    }
}