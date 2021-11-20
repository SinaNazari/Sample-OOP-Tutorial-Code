public sealed class Program
{
    static void Main(string[] args)
    {
        //Parent ch =new Parent();
        //ChildA ch = new ChildA();
        ChildB ch = new ChildB();
        ch.SayHello();
    }
}

public class Parent
{
    public virtual void SayHello()
    {
        Console.WriteLine("Hello..");
    }
}

public class ChildA : Parent
{
    public override void SayHello()
    {
        Console.WriteLine("Hi...");
    }
}

public class ChildB : ChildA
{
    public override void SayHello()
    {
        Console.WriteLine("Hello >>>>>>");
    }
}