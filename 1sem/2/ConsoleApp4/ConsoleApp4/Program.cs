using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        start:
        Console.WriteLine("Выберите арифметическое действие:\n - Умножение (введите 1)\n- Деление (введите 2)\n- " +
            "Сложение (введите 3)\n- Вычитание (введите 4)\n");
        int q = int.Parse(Console.ReadLine());
        if (q >4 || q<1)
        {
            Console.WriteLine("Вы ввели неизвестное число");
        }

        Console.WriteLine("Введите первое значение");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе значение");
        double b = double.Parse(Console.ReadLine());

        if (q == 1)
        {
            Console.WriteLine("Результат умножения = {0}", a * b);
        }
        else if (q == 2)
        {
            Console.WriteLine("Результат деления = {0}", a / b);
        }
        else if (q == 3)
        {
            Console.WriteLine("Результат сложения = {0}", a + b);
        }
        else if (q == 4)
        {
            Console.WriteLine("Результат вычитания = {0}", a - b);
        }
        
        goto start;
    }
}