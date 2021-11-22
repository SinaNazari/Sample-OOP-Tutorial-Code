class Program
{
    static void Main(string[] args)
    {
        MyDelegate myDelegate = new MyDelegate(SayHello);
        myDelegate += SayHello2;
        myDelegate += SayHello3;
        myDelegate += SayHello4;
        myDelegate("Sina Nazari");

    }

    public delegate void MyDelegate(string message);
    public static void SayHello(string name)
    {
        Console.WriteLine("hi"+" "+name);
    }

    public static void SayHello2(string name)
    {
        Console.WriteLine("How Is It Going?" + " " + name);
    }

    public static void SayHello3(string name)
    {
        Console.WriteLine("How Old Are You?" + " " + name);
    }

    public static void SayHello4(string name)
    {
        Console.WriteLine("Whats You Favorite Color?" + " " + name);
    }
}

