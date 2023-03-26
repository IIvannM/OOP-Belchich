using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Magazine : Item
    {
        private String volume; // том
        private int number; // номер
        private String title; // название
        private int year; // год выпуска

        public Magazine(String volume, int number, String title, int
            year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
        public override void Return()    // операция "вернуть"
        {
            taken = true;
        }
        public Magazine()
        { }
        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\nТом: {0}\nНомер: {1}\n" +
                "Название: {2}\nГод выпуска: {3}",
                volume, number, title, year);
            base.Show();
        }
    }
    abstract class Item
    {
        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;
        // истина, если этот предмет имеется в библиотеке

        public Item()
        {
            this.taken = true;
        }
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public bool IsAvailable()
        {
            if (taken == true)
                return true;
            else
                return false;
        }
        // инвентарный номер
        public long GetInvNumber()
        {
            return invNumber;
        }
        // операция "взять"
        private void Take()
        {
            taken = false;
        }
        // операция "вернуть"
        abstract public void Return();
        public virtual void Show()
        {
            Console.WriteLine("Состояние единицы хранения:\n" +
                "Инвентарный номер: {0}\nНаличие: {1}\n",
                invNumber, taken);
        }
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }

    }
    class Book : Item
    {
        private String author;    // автор
        private String title;     // название
        private String publisher; // издательство
        private int pages;        // кол-во страниц
        private int year;         // год издания

        private static double price = 9;

        private bool returnSrok;
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return()    // операция "вернуть"
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
        public Book()
        { }

        public Book(String author, String title, String publisher,
            int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book(String author, String title, String publisher,
            int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        static Book() //статический конструктор
        {
            price = 10;
        }
        public Book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }
        public void SetBook(String author, String title,
            String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        public override void Show()
        {
            Console.WriteLine("\nКнига:\nАвтор: {0}\nНазвание: {1}\n" +
                "Год издания: {2}\n{3}стр.\nСтоимость аренды: {4}\n",
                author, title, year, pages, Book.price);
            base.Show();
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
        /*
        public void TakeItem()
        {
            if (this.IsAvailable())
                this.Take();
        }*/
    }

    class Program
    {
        static void Main()
        {
            Book b1 = new Book();
            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс",
                123, 2012);
            Book.SetPrice(12);
            b1.Show();
            Console.WriteLine("\nИтоговая стоимость аренды: {0} p.",
                b1.PriceBook(3));
            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь",
                1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();
            Book b3 = new Book("Лермонтов М.Ю.", "Мцыри");
            b3.Show();

            // Item item1 = new Item();
            //  item1.Show();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы",
                2014, 1235, true);
            mag1.Show();

            Console.WriteLine("\nТестирование полиморфизма");

            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Show();
            Console.ReadKey();
        }
    }
}
