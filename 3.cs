using System;

public class MusicalInstrument
{
    protected string Name;

    public MusicalInstrument(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Этот инструмент издает звук.");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Инструмент: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание инструмента недоступно.");
    }

    public virtual void History()
    {
        Console.WriteLine("История создания инструмента недоступна.");
    }
}

public class Violin : MusicalInstrument
{
    public Violin() : base("Скрипка") { }

    public override void Sound()
    {
        Console.WriteLine("Звук скрипки: Вив-вив");
    }

    public override void Desc()
    {
        Console.WriteLine("Скрипка — струнный музыкальный инструмент, обычно изготавливаемый из дерева, с четырьмя струнами.");
    }

    public override void History()
    {
        Console.WriteLine("История скрипки уходит в средние века, она была популярна в Европе с XVI века.");
    }
}

public class Trombone : MusicalInstrument
{
    public Trombone() : base("Тромбон") { }

    public override void Sound()
    {
        Console.WriteLine("Звук тромбона: Бууу");
    }

    public override void Desc()
    {
        Console.WriteLine("Тромбон — медный духовой инструмент с выдвижной трубой.");
    }

    public override void History()
    {
        Console.WriteLine("История тромбона восходит к 15 веку, он использовался в военной и оркестровой музыке.");
    }
}

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Укулеле") { }

    public override void Sound()
    {
        Console.WriteLine("Звук укулеле: Тии-ри-ри");
    }

    public override void Desc()
    {
        Console.WriteLine("Укулеле — маленькая гавайская гитара с четырьмя струнами.");
    }

    public override void History()
    {
        Console.WriteLine("История укулеле связана с Гавайями, где он появился в XIX веке благодаря португальским иммигрантам.");
    }
}

public class Cello : MusicalInstrument
{
    public Cello() : base("Виолончель") { }

    public override void Sound()
    {
        Console.WriteLine("Звук виолончели: Ву-у-у");
    }

    public override void Desc()
    {
        Console.WriteLine("Виолончель — струнный инструмент, более крупный, чем скрипка, с богатым и глубоким звуком.");
    }

    public override void History()
    {
        Console.WriteLine("История виолончели восходит к XVI веку, она является важной частью оркестров и камерных ансамблей.");
    }
}

class Program
{
    static void Main()
    {
        MusicalInstrument[] instruments = new MusicalInstrument[]
        {
            new Violin(),
            new Trombone(),
            new Ukulele(),
            new Cello()
        };

        foreach (var instrument in instruments)
        {
            instrument.Show();
            instrument.Sound();
            instrument.Desc();
            instrument.History();
            Console.WriteLine(new string('-', 40));
        }
    }
}
