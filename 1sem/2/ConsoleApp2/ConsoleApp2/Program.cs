using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 100 || age < 1)
                goto start;
            int a = age % 10;
            if (a >= 2 && a <= 4)
                Console.WriteLine(age + " года");
            else if (a==1)
                Console.WriteLine(age + " год");
            else if (a == 0 || a>=5 && a<=9)
                Console.WriteLine(age + " лет");
            goto start;
        }
    }
}
