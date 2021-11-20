class Program
{
    static void Main(string[] args)
    {
        Child ch = new Child();
        ch.Id = 1;
        ch.Name = "Sina";
        ch.SayHello();
    }
}

abstract class Parent
{
    public int Id { get; set; }
    public string Name { get; set; }

    public abstract void SayHello();
    public void SayHi()
    {
        Console.WriteLine("Hi...");
    }
}

class Child : Parent
{
    public override void SayHello()
    {
        Console.WriteLine("Hello User...");
    }
}