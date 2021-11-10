//
class Program
{
    static void Main(string[] args)
    {
        //car.name = "pridy";
        //car.speed = 120;
        //car.model = "98";

        var car = new Car();
        car.name = "pikan";
        car.speed = 115;
        car.model = 91;
        //var car2 = new Car("Pikan", 200, "80");
        Console.WriteLine($"Name:{car.name} Speed:{car.speed} Model:{car.model}");
        //Console.WriteLine($"Name:{car2.name} Speed:{car2.speed} Model:{car2.model}");
    }
}

public class Car
{
    //public int speed;
    //public string name;
    //public string model;

    private string _name;
    private int _speed;
    private int _model;

    public string name { get; set; } = "Pridy";
    public int speed
    {
        get { return _speed; }
        set
        {
            if (value >= 120)
            {
                throw new Exception("Value Speed Is Not Valid...");
            }
            else
            {
                _speed = value;
            }
        }
    }
    public int model
    {
        get { return _model; }
        set
        {
            if (value < 90)
            {
                throw new Exception("This Cars is Destructor...");
            }
            else
            {
                _model = value;
            }
        }
    }


    //public Car()
    //{
    //    this.name = "Object";
    //    this.speed = 120;
    //    this.model = "90";
    //}

    //public Car(string name, int speed, string model)
    //{
    //    this.name = name;
    //    this.speed = speed;
    //    this.model = model;
    //}
    //~Car()
    //{
    //    Console.WriteLine("Destructor");
    //}
}
