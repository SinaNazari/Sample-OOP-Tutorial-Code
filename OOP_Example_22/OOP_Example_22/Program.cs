class Program
{
    static void Main(string[] args)
    {
        MyDelegate myDelegate = new MyDelegate(SayHello);
        myDelegate("Hello");

    }

    public delegate void MyDelegate(string message);
    public static void SayHello(string message)
    {
        Console.WriteLine(message);
    }
}
//    public int sum(int a, int b)
//    {
//        return a + b;
//    }

//    public string FullName(string name, string family)
//    {
//        return name + " " + family;
//    }

