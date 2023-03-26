using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    struct Company
    {
        public String Name;
        public byte Age;
        public double ZP;
        public byte Day;

        public Company(string Name, byte Age, double ZP, byte Day)
        {
            this.Name = Name;
            this.Age = Age;
            this.ZP = ZP;
            this.Day = Day;
        }

        public void WriteCompany()
        {
            Console.WriteLine("Имя: {0}, Возраст: {1}, ЗП: {2}", Name, Age, ZP);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Company user1 = new Company("Дмитрий", 33, 33000, 28);
            Console.Write("user1: ");
            user1.WriteCompany();

            Company user2 = new Company("Елена", 22, 33000, 14);
            Console.Write("user1: ");
            user2.WriteCompany();

            user1 = user2;
            user2.Name = "Наталья";
            user2.Age = 26;
            Console.WriteLine("\n\nuser1: ");
            user1.WriteCompany();
            Console.Write("user2: ");
            user2.WriteCompany();

            Console.ReadKey();
        }
    }
}
