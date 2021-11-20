class Program
{
    static void Main(string[] args)
    {
        Child ch = new Child();
        ch.id = 1;
        ch.Name = "Sina";
        ch.Family = "Nazari";
        ch.SayHello();
    }
}

//Sealed
sealed class Parent
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public void SayHello()
    {
        Console.WriteLine("Hello...");
    }
}

class Child : Parent
{

}