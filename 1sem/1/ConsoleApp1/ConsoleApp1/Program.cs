using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = -2.14;
            var x = 1.25;
            var F = ((Math.Pow((Math.E), x * a)) + ((2.73) * (Math.Pow(a, 3) * Math.Pow(x, 1/3)
                + (1.78) * Math.Pow(Math.Abs(x), 1.4)))) / (Math.Abs(x + a) + Math.Tan(((Math.PI) * a) / 2));
            Console.WriteLine($"Функция F: {(Math.Round((F/10)- 0.3,2))+"*10^1"}");
            Console.ReadKey(true);
        }
        
    }
}
