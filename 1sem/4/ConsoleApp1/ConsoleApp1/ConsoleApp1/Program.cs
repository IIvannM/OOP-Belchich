using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1_1
{
    class Triangle
    {

        // Поля
        public double a, b, c;
        public string name;
        public double area;

        // Конструктор

        public Triangle()
        { }

        public Triangle(double a, double b, double c, string name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.name = name;
        }

        // Методы
        public double Area
        {
            get { return area; }
        }

        private void ComputeArea()
        { 
            area = (Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c))); 
        }
    


        /*public double Area(double a, double b, double c)
        {
            double area = (Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
        }
        public void Per(double a, double b, double c)
        {
             double per = a+b+c;
        }*/

        public void DisplayStatus()
        {
            Console.WriteLine("\nДлина а:       {0}", A);
            Console.WriteLine("Длина b:       {0}", b);
            Console.WriteLine("Длина c:       {0}", c);
            Console.WriteLine("Имя объекта{0}",name);
        }

    }
}
namespace ConsoleApp1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle emp1 = new Triangle();

            emp1.a = 2;
            emp1.b = 1;
            emp1.c = 4;
            emp1.area = "Макеевка";
            emp1.per = "10:00";

            emp1.DisplayStatus();
            // emp1.GiveBonus(5000);
            //emp1.DisplayStatus();
            Console.ReadKey();

            Employee emp2 = new Employee(4312, 2, "Петр Петрович", "Даниловка", "11:11");
            emp2.DisplayStatus();
            // emp2.GiveBonus(7000);
            // emp2.DisplayStatus();
            Console.ReadKey();

            Employee emp3 = new Employee(1211, 3, "Иван Таранов", "Владимировка", "12:12");
            emp3.DisplayStatus();
            Console.ReadKey();

        }
    }
}
