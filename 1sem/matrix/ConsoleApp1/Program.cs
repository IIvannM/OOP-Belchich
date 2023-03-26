using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int k = 2;
            var array = new int[n, k];
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    array[i, j] = random.Next(1, 15);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}