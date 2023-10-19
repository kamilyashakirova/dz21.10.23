using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

abstract class transport
{
    public abstract string Type { get; }
    public int Number { get; set; }
    public string Color { get; set; }
    public transport(int number, string color)
    {
        Number = number;
        Color = color;
    }

    public abstract void Start();
    public abstract void Stop();
    public abstract void Park();
    public virtual void info()
    {
        Console.WriteLine("вид транспорта: " + Type);
        Console.WriteLine("количество колёс: " + Number);
        Console.WriteLine("цвет: " + Color);
    }
}

class Car : transport
{
    public override string Type => " автомобиль ";
    public string Model { get; set; }
    public string Plate { get; set; }
    public string Brand { get; set; }

    public Car(string brand, string model, string plate, string color) : base(4, color)
    {
        Brand = brand;
        Model = model;
        Plate = plate;
    }

    public override void Start()
    {
        Console.WriteLine(Brand + " начала движение");
    }

    public override void Stop()
    {
        Console.WriteLine(Brand + " заглушила двигатель");
    }

    public override void info()
    {
        base.info();
        Console.WriteLine("модель машины: " + Model);
        Console.WriteLine("номер: " + Plate);
    }
    public override void Park()
    {
        Console.WriteLine("Припарковываем автомобиль {0} {1}", Brand, Model);
    }
}

class Motorcycle : transport
{
    public override string Type => "мотоцикл";
    public string Brand { get; set; }
    public string Model { get; set; }
    public bool Helmet { get; set; }


    public Motorcycle(string brand, string model, bool helmet, string color) : base(2, color)
    {
        Brand = brand;
        Helmet = helmet;
        Model = model;
    }

    public override void Start()
    {
        Console.WriteLine(Brand + " мотоцикл начал движение");
    }

    public override void Stop()
    {
        Console.WriteLine(Brand + " мотоцикл остановился");
    }

    public override void info()
    {
        base.info();
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Has Helmet: " + Helmet);
    }
    public override void Park()
    {
        Console.WriteLine("Паркуем мотоцикл {0} {1}", Brand, Model);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Mazda", "C5", "CVB345", "Чёрный");
        car1.Start();
        car1.info();
        car1.Stop();
        car1.Park();
        Console.WriteLine();
        Motorcycle motorcycle1 = new Motorcycle("Harley-Davidson", "Fat Boy", true, "Белый");
        motorcycle1.Start();
        motorcycle1.info();
        motorcycle1.Stop();
        motorcycle1.Park();
    }
}
