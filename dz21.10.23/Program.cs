using System;
//Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета
enum type
{
    tecuschyi,
    sberegatelnyi
}

class bank
{
    private string number;
    private decimal balance;
    private type account;

    public bank(string acnumber, decimal balance, type account)
    {
        this.number = acnumber;
        this.balance = balance;
        this.account = account;
    }

    public string AccountNumber
    {
        get { return number; }
        set { number = value; }
    }

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public type AccountType
    {
        get { return account; }
        set { account = value; }
    }

    public void PrintAccount()
    {
        Console.WriteLine("Account Number: {0}", number);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Account Type: {0}", account);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета");
        bank account = new bank("11122233334444", 12345, type.tecuschyi);
        account.PrintAccount();
    }
}
//Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы номер счета генерировался сам и был уникальным.
public class bankAc
{
    private static int numbercnt = 0;
    private int accountNumber;
    private decimal balance;
    private Account accountt;

    public enum Account
    {
        tecysch,
        sbereg
    }

    public bankAc(decimal newbalance, Account type)
    {
        numbercnt++;
        accountNumber = numbercnt;
        balance = newbalance;
        accountt = type;
    }

    public int AccountNumber
    {
        get { return accountNumber; }
    }

    public decimal Balance
    {
        get { return balance; }
    }

    public Account Type
    {
        get { return accountt; }
    }
    /// <summary>
    /// вывод на экран
    /// </summary>
    public void PrintInfo()
    {
        Console.WriteLine("номер счёта: " + AccountNumber);
        Console.WriteLine("тип банквского счёта: " + Type);
        Console.WriteLine("баланс: " + Balance);
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.2. Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы номер счета генерировался сам и был уникальным.");
            bankAc account = new bankAc(112233, bankAc.Account.tecysch);
            account.PrintInfo();
            //Упражнение 7.3. Добавить в класс счет в банке два метода: снять со счета и положить на счет.
            Console.WriteLine("Упражнение 7.3. Добавить в класс счет в банке два метода: снять со счета и положить на счет.");
            account.Deposit(1234455);
            account.Withdraw(900);
            account.PrintInfo();
        }
    }
    /// <summary>
    /// полодить деньги на счёт
    /// </summary>
    /// <param name="amount"></param>
    public void Deposit(decimal amount)
    {
        balance += amount;
    }
    /// <summary>
    /// снять деньги со счёта
    /// </summary>
    /// <param name="amount"></param>
    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

}
//Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).
public class Building
{
    private static int LastNumber = 0;
    private int number;
    private int height;
    private int floors;
    private int apartments;
    private int ent;
    public Building()
    {
        number = GenerateBNumber();
    }

    public int BuildingNumber
    {
        get { return number; }
    }

    public int Height
    {
        get { return height; }
        set { height = value; }
    }

    public int Floors
    {
        get { return floors; }
        set { floors = value; }
    }

    public int Apartments
    {
        get { return apartments; }
        set { apartments = value; }
    }

    public int Entrances
    {
        get { return ent; }
        set { ent = value; }
    }
    /// <summary>
    ///чтобы узнать высоту одного этажа
    /// </summary>
    /// <returns></returns>
    public int CalcHeight()
    {
        return height / floors;
    }
    /// <summary>
    /// сколько квартир в каждом подъезде
    /// </summary>
    /// <returns></returns>
    public int CalcEntrance()
    {
        return apartments / ent;
    }
    /// <summary>
    /// сколько квартир на каждом этаже
    /// </summary>
    /// <returns></returns>
    public int CalcFloor()
    {
        return apartments / floors;
    }
    /// <summary>
    /// для генерации уникального номера здания
    /// </summary>
    /// <returns></returns>
    private int GenerateBNumber()
    {
        LastNumber++;
        return LastNumber;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Building building = new Building();
            building.Height = 105;
            building.Floors = 15;
            building.Apartments = 75;
            building.Entrances = 5;

            Console.WriteLine("Домашнее задание 7.1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).\nЗдание номер {0}", building.BuildingNumber);
            Console.WriteLine("Высота этажа: {0} м", building.CalcHeight());
            Console.WriteLine("Количество квартир в подъезде: {0}", building.CalcEntrance());
            Console.WriteLine("Количество квартир на этаже: {0}", building.CalcFloor());
        }
    }
}
