using System;


public class Ustroystvo
{
    protected string Name;

    public Ustroystvo(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Звук устройства");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Устройство: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание устройства");
    }
}

public class Chaynik : Ustroystvo
{
    private string Volume;

    public Chaynik(string name, string volume) : base(name)
    {
        Volume = volume;
    }

    public override void Sound()
    {
        Console.WriteLine("Буль-буль");
    }

    public override void Show()
    {
        Console.WriteLine($"Чайник: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Чайник с объемом {Volume}");
    }
}

public class Mikrovolnovka : Ustroystvo
{
    private int Power;

    public Mikrovolnovka(string name, int power) : base(name)
    {
        Power = power;
    }

    public override void Sound()
    {
        Console.WriteLine("Микроволны работают");
    }

    public override void Show()
    {
        Console.WriteLine($"Микроволновка: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Микроволновка мощностью {Power} Вт");
    }
}

public class Avtomobil : Ustroystvo
{
    private string Model;

    public Avtomobil(string name, string model) : base(name)
    {
        Model = model;
    }

    public override void Sound()
    {
        Console.WriteLine("Гудит двигатель");
    }

    public override void Show()
    {
        Console.WriteLine($"Автомобиль: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Автомобиль модели {Model}");
    }
}

public class Parohod : Ustroystvo
{
    private double Length;

    public Parohod(string name, double length) : base(name)
    {
        Length = length;
    }

    public override void Sound()
    {
        Console.WriteLine("Гудок парохода");
    }

    public override void Show()
    {
        Console.WriteLine($"Пароход: {Name}");
    }

    public override void Desc()
    {
        Console.WriteLine($"Пароход длиной {Length} метров");
    }
}

class Program
{
    static void Main()
    {
        Ustroystvo[] devices = new Ustroystvo[]
        {
            new Chaynik("Электрический чайник", "1.5 литра"),
            new Mikrovolnovka("Samsung", 800),
            new Avtomobil("Лада", "Granta"),
            new Parohod("Корабль", 50.0)
        };

        foreach (var device in devices)
        {
            device.Show();
            device.Desc();
            device.Sound();
            Console.WriteLine();
        }
    }
}
