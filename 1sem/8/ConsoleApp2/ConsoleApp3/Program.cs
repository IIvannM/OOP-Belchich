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
        public override void Return()    // метод "вернуть"
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
        protected long invNumber; // инвентарный номер
        protected bool taken; // хранит состояние объекта . истина, если имеется в библиотеке
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
        
        public long GetInvNumber() // инвентарный номер
        {
            return invNumber;
        }
       
        private void Take()  // операция "взять"
        {
            taken = false;
        }
        
        abstract public void Return(); // операция "вернуть"
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

        private bool returnOnTime;
        public void ReturnOnTime()
        {
            returnOnTime = true;
        }
        public override void Return()    // операция "вернуть"
        {
            if (returnOnTime == true)
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
            Book bookFrst = new Book();
            bookFrst.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс",
                123, 2012);
            Book.SetPrice(12);
            bookFrst.Show();
            Console.WriteLine("\nИтоговая стоимость аренды: {0} p.",
                bookFrst.PriceBook(3));
            Book bookSec = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь",
                1234, 2013, 131, true);
            bookSec.TakeItem();
            bookSec.Show();
            Book bookTrd = new Book("Лермонтов М.Ю.", "Мцыри");
            bookTrd.Show();

            // Item item1 = new Item();
            //  item1.Show();

            Magazine magFst = new Magazine("О природе", 5, "Земля и мы",
                2014, 5435, true);
            magFst.Show();

            Console.WriteLine("\nТестирование полиморфизма");

            Item it;
            it = bookSec;
            it.TakeItem();
            it.Return();
            it.Show();
            it = magFst;
            it.TakeItem();
            it.Return();
            it.Show();
            Console.ReadKey();
        }
    }
}
