using System.Collections.Generic;
using System;

abstract class Persona  //основной абстрактный класс
                        
{
    string name;
    DateTime birthDay; // ввод переменной как datetime позволяет в дальнейшем оперировать с ней относительно текущей даты

    public DateTime BirthDay    //свойство
    {
        get { return birthDay; }
        set { if (birthDay.Year > 1930 && birthDay.Year < 2004) birthDay = value; } //проверка введенных данных
    }

    public string Name  //свойство
    {
        get { return name; }
        set { name = value; }
    }

    public Persona(string name, DateTime birthDay)  //конструктор
    {
        this.name = name;
        this.birthDay = birthDay;
    }

    public abstract void write_inf();   //вывод по умолчанию


    public int Age { get { return DateTime.Now.Year - birthDay.Year; } }


}

class Admin : Persona//производный класс "Администратор"
{
    string laboratory;

    public string Laboratory
    {
        get { return laboratory; }
        set { if (laboratory == "Кибербизопасности" || laboratory == "Инфокоммуникационного обеспечения") laboratory = value; }
    }

    public Admin(string name, DateTime birthDay, string laboratory)
        : base(name, birthDay)
    {
        this.laboratory = laboratory;
    }

    public override void write_inf() //перегр вывод
    {
        Console.WriteLine("Имя - {0}, Возраст - {1}, Лаборатория {2}", Name, this.Age, laboratory);
    }
}

class Student : Persona     //производный класс "Студент"
{
    string faculty;
    int kourse;

    public string Faculty
    {
        get { return faculty; }
        set { if (faculty == "Системное администрирование" || faculty == "Программное обоспечение КС") faculty = value; }
    }

    public int Kourse
    {
        get { return kourse; }
        set { if (kourse > 0 && kourse < 5) kourse = value; }
    }

    public Student(string name, DateTime birthDay, string faculty, int kourse)
        : base(name, birthDay)
    {
        this.faculty = faculty;
        this.kourse = kourse;
    }

    public override void write_inf()
    {
        Console.WriteLine("Имя - {0}, Возраст - {1}, Факультет - {2}, Курс - {3}", Name, this.Age, faculty, kourse);
    }
}

class Teacher : Persona//производный класс "Преподаватель"
{
    string faculty;
    int exp;

    public string Faculty
    {
        get { return faculty; }
        set { if (faculty == "Системное администрирование" || faculty == "Программное обоспечение КС") faculty = value; }
    }

    public int Exp
    {
        get { return exp; }
        set { if (exp > 0 && exp < 60) exp = value; }
    }

    public Teacher(string name, DateTime birthDay, string faculty, int exp)
        : base(name, birthDay)
    {
        this.faculty = faculty;
        this.exp = exp;
    }

    public override void write_inf()
    {
        Console.WriteLine("Имя - {0}, Возраст - {1}, Факультет - {2}, Cтаж - {3}", Name, this.Age, faculty, exp);
    }
}

class Manager : Persona//производный класс "Менеджер"
{
    string faculty;
    string job;

    public string Faculty
    {
        get { return faculty; }
        set { if (faculty == "Системное администрирование" || faculty == "Программное обеспечение КС") faculty = value; }
    }

    public string Job
    {
        get { return job; }
        set { if (job == "Системное администрирование" || job == "Программное обеспечение КС") job = value; }
    }

    public Manager(string name, DateTime birthDay, string faculty, string job)
        : base(name, birthDay)
    {
        this.faculty = faculty;
        this.job = job;
    }

    public override void write_inf()
    {
        Console.WriteLine("Имя - {0}, Возраст - {1}, Факультет - {2}, Должность - {3}", Name, this.Age, faculty, job);
    }
}

class Program
{

    static void Main(string[] args)
    {
        List<Persona> persons = new List<Persona>();
        persons.Add(new Student("Иван", new DateTime(2004, 2, 23), "Системное администрирование", 4));
        persons.Add(new Student("Андрей", new DateTime(2003, 4, 22), "Программное обеспечение КС", 4));
        persons.Add(new Admin("Петр", new DateTime(1996, 2, 23), "Инфокоммуникационного обеспечения"));
        persons.Add(new Teacher("Василий", new DateTime(1980, 2, 23), "Системное администрирование", 12));
        persons.Add(new Manager("Сергей", new DateTime(1970, 2, 23), "Программное обеспечение КС", "Управляющий по закупкам"));
        foreach (Persona p in persons)
        {
            if (p is Student)
                Console.Write("Студент ");
            else if (p is Admin)
                Console.Write("Администратор ");
            else if (p is Manager)
                Console.Write("Менеджер ");
            else
                Console.Write("Преподователь ");
            p.write_inf();
        }

        Console.WriteLine("\nПерсоны старше 30 лет ");

        foreach (Persona p in persons)
        {
            if (p.Age > 30)
                p.write_inf();
        }

        Console.ReadKey();

    }


}