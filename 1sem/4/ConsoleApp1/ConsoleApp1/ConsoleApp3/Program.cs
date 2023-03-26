using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Retangle
    {
        private double a, b;     //поля
        private string name;

        public string Check      //методы
        {
            get
            {
                if (a == b)
                    return "данный прямоугольник - квадрат";
                else
                    return "Данный прямоугольник не квадрат";
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
                        Console.WriteLine("Сторона прямоугольника не может " +
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
                        Console.WriteLine("Сторона прямоугольника " +
                            "не может иметь отрицательное значение или " +
                            "быть равной нулю!");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    b = value;
                }
            }
        }
        

        public Retangle()    //конструкторы
        {
            a = 0;
            b = 0;
            
            name = "Retangle Default";
        }
        public Retangle(string name)
        {
            a = 2;
            b = 5;
            this.name = name;
        }

        public Retangle(double a, double b, string name)
        {
            this.a = a;
            this.b = b;
            this.name = name;
        }

        public void ShowSidesValues()
        {
            Console.WriteLine("Стороны прямоугольника равны: {0}; {1}",
                a, b);
        }

        public void ShowName()
        {
            Console.WriteLine("Имя прямоугольника: {0}", name);
        }

        public void CalculatePerimeter()
        {
            Console.WriteLine("Периметр прямоугольника равен: {0}",
                (a + b)*2 );
        }

        public void CalculateArea()
        {

            Console.WriteLine("Площадь прямоугольника равна: {0}", (a*b));

        }
    }

    class Program
    {
        static void Main()
        {
            double aFr, bFr;
            string nFr;

            var ex = new Retangle();
            ex.ShowSidesValues();
            ex.CalculatePerimeter();
            ex.CalculateArea();
            ex.ShowName();
            Console.WriteLine(ex.Check);
            Console.WriteLine("\n#####\n");

            var ex1 = new Retangle("Retangle ex1");
            ex1.ShowSidesValues();
            ex1.CalculatePerimeter();
            ex1.CalculateArea();
            ex1.ShowName();
            Console.WriteLine(ex1.Check);
            Console.WriteLine("\n#####\n");

            var ex2 = new Retangle(2, 6, "Retangle ex2");
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
            Console.WriteLine("Имя прямоугольника: "); //name
            ex.Name = Console.ReadLine();
            nFr = ex.Name;

            var ex3 = new Retangle(aFr, bFr, nFr);
            ex3.ShowSidesValues();
            ex3.CalculatePerimeter();
            ex3.CalculateArea();
            ex3.ShowName();
            Console.WriteLine(ex3.Check);
            Console.WriteLine("\n#####\n");

            Console.WriteLine("1 - создать новый прямоугольник\n0 - выход \n");
            int exit = Convert.ToInt32(Console.ReadLine());
            if (exit == 1)
                goto triangle3;
            else
                Environment.Exit(0);

        }
    }
}
