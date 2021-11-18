class Program
{
    static void Main(string[] args)
    {
        Employees e=new Employees();
        e.name = "Sina";
        e.family = "Nazari";
        e.SayHello();
    }
}

class Person
{
    public string name;

    public void SayHello()
    {
        Console.WriteLine("Hello" + " " + name);
    }
}

class Employees : Person
{
    public string family;

    public new void SayHello()
    {
        Console.WriteLine("Hello"+" "+name+" "+family);
        base.SayHello();
    }
}