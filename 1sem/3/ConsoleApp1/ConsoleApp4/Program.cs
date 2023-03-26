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
            int a, b;

            a = -1;
            b = -1;


            while (true)
            {
                Console.WriteLine("Вы введите первое число от 0 до 10: ");
                a = Convert.ToInt16(Console.ReadLine());

                if (0 <= a && a <= 10)
                    break;
            }

            while (true)
            {
                Console.WriteLine("Вы введите второе число от 0 до 10: ");
                b = Convert.ToInt16(Console.ReadLine());

                if (0 <= b && b <= 10)
                    break;
            }

            Console.WriteLine("Результат умножения: " + a * b);

            Console.ReadKey();
        }
    }
}
