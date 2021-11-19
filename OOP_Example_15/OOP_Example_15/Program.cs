class Program
{
    static void Main(string[] args)
    {
        Child ch = new Child();
        ch.Name = "Sina";
        ch.Family = "Nazari";
        ch.SayHello();
    }
}

class Parent
{
    public string Name { get; set; }
    public string Family { get; set; }

    public virtual void SayHello()
    {
        Console.WriteLine("Hello" + " " + Name + " " + Family);
    }
}

class Child : Parent
{
    public override void SayHello()
    {
        base.SayHello();
        Console.WriteLine("Bye My Friend" + " " + Name + " " + Family);
    }
}