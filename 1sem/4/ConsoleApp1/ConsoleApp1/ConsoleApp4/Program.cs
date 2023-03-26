using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Money
    {
        private int first, second, n;

        public Money()
        {
            first = 50;
            second = 2;
            n = 5000;
        }
        public Money(int first, int second, int n)
        {
            this.first = first;
            this.second = second;
            this.n = n;
        }

        public int First
        {
            get { return first; }
            set
            {
                if (value > 0)
                    first = value;
                else
                {
                    var have = new List<int> { 10, 50, 100, 200,
                        500, 1000, 2000, 5000 };
                    while (value < 0)
                    {
                        Console.WriteLine("Номинал не может быть меньше нуля");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    while (have.Contains(value) == false)
                    {
                        Console.WriteLine("Купюр такого номинала не существует!" +
                            " Cписок существующего номинала: " +
                            "10, 50, 100, 200, 500, 1000, 2000, 5000");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    first = value;
                }
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value > 0)
                    second = value;
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("Количество купюр не может" +
                            " быть меньше нуля!");
                        Console.WriteLine("Попробуйте снова");
                        value = int.Parse(Console.ReadLine());
                    }
                    second = value;
                }
            }
        }
        public int Sum
        {
            get { return first * second; }

        }
        public void ShowValues()
        {
            Console.WriteLine("Номинал: {0}\nКоличество купюр: {1}",
                first, second);
        }
        public void CalculatorEnough()
        {
            if (n - first * second <= 0)
                Console.WriteLine("Денежных средств на покупку товара " +
                    "на сумму {0} будет достаточно", n);
            else
                Console.WriteLine("Денежных средств на покупку товара " +
                    "на сумму {0} не будет достаточно", n);
        }
        public void CalculatorHowMany()
        {
            Console.WriteLine("{0} шт. товара можно купить на имеющиеся " +
                "денежные средства", (first * second) / n);
        }
    }

    class Program
    {
        static void Main()
        {
            int firstFromMain, secondFromMain;
            var ex = new Money();
            ex.ShowValues();
            Console.WriteLine("Сумма: {0}", ex.Sum);
            ex.CalculatorEnough();
            ex.CalculatorHowMany();

            Console.WriteLine("\n");

            ex.First = int.Parse(Console.ReadLine());
            firstFromMain = ex.First;
            ex.Second = int.Parse(Console.ReadLine());
            secondFromMain = ex.Second;
            var ex1 = new Money(firstFromMain, secondFromMain, 2000);
            ex1.ShowValues();
            Console.WriteLine("Сумма: {0}", ex1.Sum);
            ex1.CalculatorEnough();
            ex1.CalculatorHowMany();
            Console.ReadKey();
        }
    }
}
