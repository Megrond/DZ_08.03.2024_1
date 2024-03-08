
/* Задание  1
Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
В классе должны быть предусмотрены поле для хранения целой части денег(доллары, евро, гривны и т.д.) и поле
для хранения копеек (центы, евроценты, копейки и т.д.).
Реализовать методы для вывода суммы на экран, задания значений для частей.
На базе класса Money создать класс Product для работы
с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
Для каждого из классов реализовать необходимые
методы и поля.*/
using System;

public class Money
{
    public int Dollars { get; set; }
    public int Cents { get; set; }

    public Money(int dollars, int cents)
    {
        this.Dollars = dollars;
        this.Cents = cents;
    }

    public void DisplayAmount()
    {
        Console.WriteLine($"Количество: {Dollars} доллары {Cents} центы");
    }

    public void SetAmount(int dollars, int cents)
    {
        this.Dollars = dollars;
        this.Cents = cents;
    }
}

public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void ReducePrice(int reductionAmount)
    {
        int totalCents = this.Price.Dollars * 100 + this.Price.Cents;
        totalCents -= reductionAmount;

        this.Price.Dollars = totalCents / 100;
        this.Price.Cents = totalCents % 100;
    }
}

class Program
{
    static void Main()
    {
        Money money = new Money(10, 50);
        money.DisplayAmount();
        money.SetAmount(15, 75);
        money.DisplayAmount();

        Money productPrice = new Money(25, 99);
        Product product = new Product("Образец продукта", productPrice);

        Console.WriteLine($"Первоначальная цена {product.Name}:");
        product.Price.DisplayAmount();

        product.ReducePrice(10);
        Console.WriteLine($"Цена после снижения на 10$:");
        product.Price.DisplayAmount();
    }
}

/*================================================================================================*/

/* Задание 2
Создать базовый класс «Устройство» и производные
классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». С помощью конструктора установить имя каждого
устройства и его характеристики.
Реализуйте для каждого из классов методы:
■ Sound — издает звук устройства (пишем текстом в
консоль);
1
■ Show — отображает название устройства;
■ Desc — отображает описание устройства*/
/*class Device
{
    protected string name;
public Device(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Устройство издает звук");
    }

    public void Show()
    {
        Console.WriteLine("Устройство: " + name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Это устройство");
    }
}

class Kettle : Device
{
    public Kettle(string name) : base(name) {}
    

public override void Sound()
    {
        Console.WriteLine("Чайник кипятит воду");
    }

    public override void Desc()
    {
        Console.WriteLine("Это чайник, в котором кипятят воду.");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name) {}


public override void Sound()
    {
        Console.WriteLine("Микроволновка греет еду");
    }

    public override void Desc()
    {
        Console.WriteLine("Это микроволновая печь, используемая для разогрева еды");
    }
}

class Car : Device
{
    public Car(string name) : base(name) {}

public override void Sound()
    {
        Console.WriteLine("Двигатель автомобиля работает");
    }

    public override void Desc()
    {
        Console.WriteLine("Это автомобиль, используемый для перевозки");
    }
}

class Ship : Device
{
    public Ship(string name) : base(name) {}
public override void Sound()
    {
        Console.WriteLine("Корабельный гудок дует");
    }

    public override void Desc()
    {
        Console.WriteLine("Это корабль, используемый для путешествий по воде.");
    }
}

class Program
{
    static void Main()
    {
        Device kettle = new Kettle("Электрический чайник");
        kettle.Show();
        kettle.Sound();
        kettle.Desc();

        Device microwave = new Microwave("Микроволновая печь");
        microwave.Show();
        microwave.Sound();
        microwave.Desc();

        Device car = new Car("Электромобиль");
        car.Show();
        car.Sound();
        car.Desc();

        Device ship = new Ship("Круизное судно");
        ship.Show();
        ship.Sound();
        ship.Desc();
    }
}*/

/*================================================================================================*/

/* Задание 3
Создать базовый класс «Музыкальный инструмент»
и производные классы «Скрипка», «Тромбон», «Укулеле»,
«Виолончель». С помощью конструктора установить имя
каждого музыкального инструмента и его характеристики.
Реализуйте для каждого из классов методы:
■ Sound — издает звук музыкального инструмента
(пишем текстом в консоль);
■ Show — отображает название музыкального инструмента;
■ Desc — отображает описание музыкального инструмента;
■ History — отображает историю создания музыкального инструмента.*/

/*class MusicalInstrument
{
    protected string name;

    public MusicalInstrument(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{name} производит звук.");
    }

    public void Show()
    {
        Console.WriteLine($"Музыкальный инструмент: {name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"Описание {name}");
    }

    public virtual void History()
    {
        Console.WriteLine($"История {name}");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine($"{name} производит звук скрипки.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Описание {name}: Струнный инструмент.");
    }

    public override void History()
    {
        Console.WriteLine($"История {name}: Возник в 16 веке.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine($"{name} издает звук тромбона.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Описание {name}: Духовой инструмент.");
    }

    public override void History()
    {
        Console.WriteLine($"История {name}: Возник в 15 веке.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine($"{name} производит звук гавайской гитары.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Описание {name}: Небольшой инструмент, похожий на гитару.");
    }

    public override void History()
    {
        Console.WriteLine($"История {name}: Возник на Гавайях в 19 веке..");
    }
}
class Cello : MusicalInstrument
{
    public Cello(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine($"{name} производит звук виолончели.");
    }

    public override void Desc()
    {
        Console.WriteLine($"Описание {name}: Струнный инструмент.");
    }

    public override void History()
    {
        Console.WriteLine($"История {name}: Возникает в 16 веке и произошел от других струнных инструментов..");
    }
}
class Program
{
    static void Main()
    {
        Violin violin = new Violin("Скрипка");
        violin.Sound();
        violin.Show();
        violin.Desc();
        violin.History();

        Trombone trombone = new Trombone("Тромбон");
        trombone.Sound();
        trombone.Show();
        trombone.Desc();
        trombone.History();

        Ukulele ukulele = new Ukulele("Гавайская гитара");
        ukulele.Sound();
        ukulele.Show();
        ukulele.Desc();
        ukulele.History();

        Cello cello = new Cello("Виолончель");
        cello.Sound();
        cello.Show();
        cello.Desc();
        cello.History();
    }
}*/

/*================================================================================================*/

/* Задание 4
Создать абстрактный базовый классWorker(работника)
с методом Print(). Создайте четыре производных класса:
President, Security, Manager, Engineer. Переопределите метод
Print() для вывода информации, соответствующей
каждому типу работника.*/

/*public abstract class Worker
{
    public abstract void Print();
}

public class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("Президент: управляет всей деятельностью компании.");
    }
}

public class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Охраник: обеспечивает безопасность и безопасность помещений компании.");
    }
}

public class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Менеджер: контролирует команду сотрудников и обеспечивает соблюдение сроков проекта.");
    }
}

public class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Инженер: проектирует и разрабатывает технические решения проектов.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        President president = new President();
        Security security = new Security();
        Manager manager = new Manager();
        Engineer engineer = new Engineer();

        president.Print();
        security.Print();
        manager.Print();
        engineer.Print();
    }
}*/
