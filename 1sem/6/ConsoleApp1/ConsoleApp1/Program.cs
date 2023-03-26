using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
// y = (a-b)^2
namespace PR6
{
    class Vals
    {
        private double a ;
        public double b ;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }   


    }
}

namespace PR6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vals ival = new Vals();
            Console.WriteLine("y=(a-b)^2");
            Console.WriteLine("Первое число: ");
            ival.A =  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            ival.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y= {0}",Math.Pow((ival.A-ival.b),2));
            
            Console.ReadKey();
        }
    }
}