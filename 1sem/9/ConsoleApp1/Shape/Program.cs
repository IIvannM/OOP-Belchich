using System;
using System.Security.Policy;

namespace Shape
{
    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle() { }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void ShowArea()
        {
            Console.WriteLine($"Площадь треугольника: {Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c))}");
        }
        public override void ShowPerimeter()
        {
            Console.WriteLine($"Периметр треугольника: {a + b + c}");
        }
        public virtual double Counter()
        {
            return (Math.PI * Math.Pow(b, 2) * c) / 3; //доп задание - вращение вокруг центра - конус
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle() { }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void ShowArea()
        {
            Console.WriteLine($"Площадь круга: {Math.PI * Math.Pow(radius, 2)}");
        }
        public override void ShowPerimeter()
        {
            Console.WriteLine($"Периметр круга: {2 * Math.PI * radius}");
        }
        public void ShowParameters() { Console.WriteLine($"Радиус круга: {radius}"); }
    }
    class Square : Shape
    {
        private double side;
        public Square() { }
        public Square(double side)
        {
            this.side = side;
        }
        public override void ShowArea()
        {
            Console.WriteLine($"Площадь квадрата: {side * side}");
        }
        public override void ShowPerimeter()
        {
            Console.WriteLine($"Периметр квадрата: {side * 4}");
        }
        public virtual double Counter() //доп задание - вращение вокруг центра - цилиндр
        {
            return Math.PI * Math.Pow(side, 3);
        }
        public void ShowParameters() { Console.WriteLine($"Сторона квадрата: {side}"); }
    }
    class Shape
    {
        public virtual void ShowArea() { }
        public virtual void ShowPerimeter() { }
        public interface Capacity
        {
            double Counter();
        }
    }

    class Program
    {
        static void Main()
        {
            var triangle = new Triangle(3, 4, 5);
            triangle.ShowArea();
            triangle.ShowPerimeter();
            Console.WriteLine("\n#####\n");
            Console.WriteLine($"Объём конуса: {triangle.Counter()}"); //доп задание - вращение вокруг центра
            Console.WriteLine("\n#####\n");
            var square = new Square(8);
            square.ShowParameters();
            square.ShowArea();
            square.ShowPerimeter();
            Console.WriteLine("\n#####\n");
            Console.WriteLine($"Объём цилиндра: {square.Counter()}"); //доп задание - вращение вокруг центра
            Console.WriteLine("\n#####\n");
            var circle = new Circle(8);
            circle.ShowParameters();
            circle.ShowArea();
            circle.ShowPerimeter();
            Console.ReadKey();
        }
    }
}
