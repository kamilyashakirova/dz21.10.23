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
        Console.WriteLine("вид транспорта: {0}", Type);
        Console.WriteLine("количество колёс: {0}", Number);
        Console.WriteLine("цвет: {0}", Color);
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
        Console.WriteLine("{0} начала движение", Brand);
    }

    public override void Stop()
    {
        Console.WriteLine("{0} заглушила двигатель", Brand);
    }

    public override void info()
    {
        base.info();
        Console.WriteLine("модель машины: {0}", Model);
        Console.WriteLine("номер: {0}", Plate);
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
        Console.WriteLine("{0} мотоцикл начал движение", Brand);
    }

    public override void Stop()
    {
        Console.WriteLine("{0} мотоцикл остановился", Brand);
    }

    public override void info()
    {
        base.info();
        Console.WriteLine("Brand: {0}", Brand);
        Console.WriteLine("Has Helmet: {0}", Helmet);
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
