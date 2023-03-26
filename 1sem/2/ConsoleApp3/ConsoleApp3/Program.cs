using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program3
{
    public static void Main(string[] args)
    {
        start:
        Console.WriteLine("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Уравнение: ");
        Console.WriteLine(a + "x^2 + " + b + "x + " + c);

        if (a == 0 && b == 0 && c == 0)
            Console.WriteLine("Корней бесконечное множество, x - любое число");
        else if (a == 0 && b == 0 && c != 0)
            Console.WriteLine("Нет корней");
        else if (a == 0 && b != 0)
            Console.WriteLine("x = " + (-c / b));
        else if (a != 0)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("x1 = " + Math.Round((-b + Math.Sqrt(d)) / (2 * a), 3));
            Console.WriteLine("x2 = " + Math.Round((-b - Math.Sqrt(d)) / (2 * a), 3));
        }
        goto start;
    }
}