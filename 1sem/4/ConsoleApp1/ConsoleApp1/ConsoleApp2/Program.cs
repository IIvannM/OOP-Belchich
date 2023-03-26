using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Triangle
    {
        private double a, b, c;     //поля
        private string name;

        public string Check      //методы
        {
            get
            {
                if (a + b > c && a + c > b && c + b > a)
                    return "данный треугольник существует";
                else
                    return "Данный треугольник не существует";
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Сторона треугольника не может " +
                            "иметь отрицательное значение или " +
                            "быть равной нулю");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    a = value;
                }
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Сторона треугольника " +
                            "не может иметь отрицательное значение или " +
                            "быть равной нулю!");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    b = value;
                }
            }
        }
        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                    c = value;
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Сторона треугольника " +
                            "не может иметь отрицательное значение или " +
                            "быть равной нулю!");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    c = value;
                }
            }
        }

        public Triangle()    //конструкторы
        {
            a = 0;
            b = 0;
            c = 0;
            name = "Triangle Default";
        }
        public Triangle(string name)
        {
            a = 2;
            b = 5;
            c = 4;
            this.name = name;
        }

        public Triangle(double a, double b, double c, string name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.name = name;
        }

        public void ShowSidesValues()
        {
            Console.WriteLine("Стороны треугольника равны: {0}; {1}; {2}",
                a, b, c);
        }

        public void ShowName()
        {
            Console.WriteLine("Имя треугольника: {0}",name);
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Периметр треугольника равен: {0}",
                a + b + c);
        }

        public void CalculateArea()
        {
            string area = Convert.ToString(Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) *
                ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
            
            Console.WriteLine("Площадь треугольника равна: {0}",area);
                
        }
    }

    class Program
    {
        static void Main()
        {
            double aFr, bFr, cFr;
            string nFr;

            var ex = new Triangle();
            ex.ShowSidesValues();
            ex.CalculatePerimeter();
            ex.CalculateArea();
            ex.ShowName();
            Console.WriteLine(ex.Check);
            Console.WriteLine("\n#####\n");

            var ex1 = new Triangle("Triangle ex1");
            ex1.ShowSidesValues();
            ex1.CalculatePerimeter();
            ex1.CalculateArea();
            ex1.ShowName();
            Console.WriteLine(ex1.Check);
            Console.WriteLine("\n#####\n");

            var ex2 = new Triangle(2, 6, 3, "Triangle ex2");
            ex2.ShowSidesValues();
            ex2.CalculatePerimeter();
            ex2.CalculateArea();
            ex2.ShowName();
            Console.WriteLine(ex2.Check);
            Console.WriteLine("\n#####\n");

            triangle3:
            Console.WriteLine("Первая сторона: ");//1
            ex.A = double.Parse(Console.ReadLine());
            aFr = ex.A;
            Console.WriteLine("Вторая сторона: ");//2
            ex.B = double.Parse(Console.ReadLine());
            bFr = ex.B;
            Console.WriteLine("Третья сторона: "); //3
            ex.C = double.Parse(Console.ReadLine());
            cFr = ex.C;
            Console.WriteLine("Имя треугольника: "); //name
            ex.Name = Console.ReadLine();
            nFr = ex.Name;

            var ex3 = new Triangle(aFr, bFr, cFr, nFr);
            ex3.ShowSidesValues();
            ex3.CalculatePerimeter();
            ex3.CalculateArea();
            ex3.ShowName();
            Console.WriteLine(ex3.Check);
            Console.WriteLine("\n#####\n");
            
            Console.WriteLine("1 - создать новый треугольник\n0 - выход \n");
            int exit = Convert.ToInt32(Console.ReadLine());
            if (exit==1)
                goto triangle3;
            else
                Environment.Exit(0);

        }
    }
}
