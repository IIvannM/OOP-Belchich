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
            byte month;
            int amount;

            Console.WriteLine("Введите продолжительность вклада: ");
            month = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Введите сумму вклада: ");
            amount = Convert.ToInt32(Console.ReadLine());

            int i = 1;
           
            while (i <= month)
            {
                
                amount = (amount * 107) / 100;
                Console.WriteLine("{0} месяц - сумма с начислением - {1}", i, amount);
                i++;
            }

            Console.ReadKey();
        }
    }
}
