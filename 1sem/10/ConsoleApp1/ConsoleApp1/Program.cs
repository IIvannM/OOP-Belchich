using System;

namespace ConsoleApp1
{
    class Magazine : Item, IPubs
    {
        private String volume; // том
        private int number; // номер
        private String title; // название
        private int year; // год выпуска

        public bool IfSubs { get; set; }

        public void Subs()
        {
            Console.WriteLine("Подписка на журнал \"{0}\": {1}.", title, IfSubs);
        }

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
    abstract class Item : IComparable
    {
        // инвентарный номер — целое число
        protected long invNumber;
        // хранит состояние объекта - взят ли на руки
        protected bool taken;
        // истина, если этот предмет имеется в библиотеке

        int IComparable.CompareTo(object obj)
        {
            Item it = (Item)obj;
            if (this.invNumber == it.invNumber) return 0;
            else if (this.invNumber > it.invNumber) return 1;
            else return -1;
        }

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

    class Operation
    {
        public static void PrintTitle(Book book)
        {
            book.Show();
        }

        public static void MetodObrabotchik(Book b)
        {
            Console.WriteLine("Книга {0} сдана в срок.", b.ToString());
        }
    }

    class Book : Item
    {
        private String author;    // автор
        private String title;     // название
        private String publisher; // издательство
        private int pages;        // кол-во страниц
        private int year;         // год издания

        public delegate void ProcessBookDelegate(Book book);
        public static event ProcessBookDelegate RetSrok;

        private static double price = 9;

        private bool returnSrok = false;
        public bool ReturnSrok
        {
            get
            {
                return returnSrok;
            }

            set
            {
                returnSrok = value;

                if (ReturnSrok == true)
                    RetSrok?.Invoke(this);
            }
        }

        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            if (returnSrok)
                processBook(this);
        }

        public override string ToString()
        {
            string str = this.title = ", " + this.author + " Инв. номер " + this.invNumber;

            return str;
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

    interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
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
            mag1.IfSubs = true;
            mag1.Subs();

            Item[] itmas = new Item[4];
            itmas[0] = b1;
            itmas[1] = b2;
            itmas[2] = b3;
            itmas[3] = mag1;
            Array.Sort(itmas);

            Console.WriteLine("\n#######");
            Console.WriteLine("Сортировка по инвентарному номеру");
            Console.WriteLine("#######\n");
            foreach (Item x in itmas)
            {
                x.Show();
            }

            Book b4 = new Book("Толстой Л. Н.", "Анна Каренина", "Знание", 1204, 2014, 103, true);
            Book b5 = new Book("Неш Т.", "Программирование для профессионалов", "Вильямс", 1200, 2014, 108, true);

            b4.ReturnSrok = true;
            b5.ReturnSrok = false;

            Console.WriteLine("\nКниги возвращены в срок:");
            b4.ProcessPaperbackBooks(Operation.PrintTitle);
            b5.ProcessPaperbackBooks(Operation.PrintTitle);

            Book.RetSrok += new Book.ProcessBookDelegate(Operation.MetodObrabotchik);
            b4.ProcessPaperbackBooks(Operation.MetodObrabotchik);
            Console.ReadKey();
        }
    }
}
