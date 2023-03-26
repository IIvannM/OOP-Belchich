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
            Console.WriteLine("Первое число: ");
            int fst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье число: ");
            int trd = Convert.ToInt32(Console.ReadLine());
            if (fst > 2 && fst < 5)
                Console.WriteLine(fst+"\n");
            else if (fst == 2 || fst == 5)
                Console.WriteLine(fst + " - на границе интервала" + "\n");
            
            if (sec > 2 && sec < 5)
                Console.WriteLine(sec + "\n");
            else if (sec == 2 || sec == 5)
                Console.WriteLine(sec + " - на границе интервала" + "\n");
            
            if (trd > 2 && trd < 5)
                Console.WriteLine(trd + "\n");
            else if (trd == 2 || trd == 5)
                Console.WriteLine(trd + " - на границе интервала" + "\n");
            
            Console.ReadKey();

        }
    }
}
