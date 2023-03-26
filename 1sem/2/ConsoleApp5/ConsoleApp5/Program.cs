using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConsoleApp5
{
    public static void Main(string[] args)
    {
    start:
        Console.WriteLine("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        if (x > 0 && x < 2)
            switch (x)
            {
                case 1:
                    Console.WriteLine("y= {0:0.00000}" , Math.Max(a, b));
                    break;
                case 0:
                    Console.WriteLine("y= {0:0.00000}", Math.Min(a, b));
                    break;
            }
        else
            Console.WriteLine("y= {0:0.00000}", Math.Abs(a + b));

        goto start;
    }
}