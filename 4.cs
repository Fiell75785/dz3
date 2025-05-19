using System;

public abstract class Worker
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Worker(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void Print();
}

public class President : Worker
{
    public string CompanyName { get; set; }

    public President(string name, int age, string companyName)
        : base(name, age)
    {
        CompanyName = companyName;
    }

    public override void Print()
    {
        Console.WriteLine($"Президент: {Name}, Возраст: {Age}, Компания: {CompanyName}");
    }
}

public class Security : Worker
{
    public string Department { get; set; }

    public Security(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void Print()
    {
        Console.WriteLine($"Охранник: {Name}, Возраст: {Age}, Отдел: {Department}");
    }
}

public class Manager : Worker
{
    public string Department { get; set; }

    public Manager(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void Print()
    {
        Console.WriteLine($"Менеджер: {Name}, Возраст: {Age}, Отдел: {Department}");
    }
}

public class Engineer : Worker
{
    public string Specialty { get; set; }

    public Engineer(string name, int age, string specialty)
        : base(name, age)
    {
        Specialty = specialty;
    }

    public override void Print()
    {
        Console.WriteLine($"Инженер: {Name}, Возраст: {Age}, Специальность: {Specialty}");
    }
}

class Program
{
    static void Main()
    {
        Worker[] workers = new Worker[]
        {
            new President("Иван Иванов", 55, "TechCorp"),
            new Security("Петр Петров", 40, "Security Department"),
            new Manager("Алексей Алексеев", 35, "Sales"),
            new Engineer("Светлана Смирнова", 29, "Software Development")
        };

        foreach (var worker in workers)
        {
            worker.Print();
        }
    }
}
