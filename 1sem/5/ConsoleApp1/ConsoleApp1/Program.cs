using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1_1
{
    class Airport
    {

        // Поля
        public int reis;
        public int number;
        public string type;
        public string dest;
        public string stime;

        // Конструктор

        public Airport()
        { }

        public Airport(int reis, int number, string type, string dest, string stime)
        {
            this.reis = reis;
            this.number = number;
            this.type = type;
            this.dest = dest;
            this.stime = stime;
        }

        

        public void DisplayStatus()
        {
            Console.WriteLine("\nРейс:                 {0}", reis);
            Console.WriteLine("Номер самолёта:       {0}", number);
            Console.WriteLine("Тип самолета:         {0}", type);
            Console.WriteLine("Точка назначения:     {0}", dest);
            Console.WriteLine("Время вылета:         {0}", stime);

        }

    }
}
namespace ConsoleApp1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport ap1 = new Airport();

            ap1.reis = 2312;
            ap1.number = 1;
            ap1.type = "Aerobus";
            ap1.dest = "Макеевка";
            ap1.stime = "10:00";

            ap1.DisplayStatus();
            Console.ReadKey();

            Airport ap2 = new Airport(4312, 2,"Aerobus", "Даниловка", "11:11");
            ap2.DisplayStatus();
            Console.ReadKey();

            Airport ap3 = new Airport(1211, 3, "LightFly", "Владимировка", "12:12");
            ap3.DisplayStatus();
            Console.ReadKey();

        }
    }
}
