//
class Program
{
    static void Main(string[] args)
    {
        //car.name = "pridy";
        //car.speed = 120;
        //car.model = "98";

        var car = new Car();
        var car2 = new Car("Pikan", 200, "80");
        Console.WriteLine($"Name:{car.name} Speed:{car.speed} Model:{car.model}");
        Console.WriteLine($"Name:{car2.name} Speed:{car2.speed} Model:{car2.model}");
    }
}

public class Car
{
    public int speed;
    public string name;
    public string model;

    public Car()
    {
        this.name = "Object";
        this.speed = 120;
        this.model = "90";
    }

    public Car(string name, int speed, string model)
    {
        this.name = name;
        this.speed = speed;
        this.model = model;
    }
    //~Car()
    //{
    //    Console.WriteLine("Destructor");
    //}
}
