
//Pass By Reference Parameters
class Program
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();
        int a = 8;
        int b = 3;
        int sum = my.Sum(ref a, ref b);

        int x;
        my.My(out x);

        MyClass.ShowPerson("Sina", 20, "Ali", "Reza", "Mina", "Sara", "Mammad");

    }
}

class MyClass
{
    public int Sum(ref int a, ref int b)
    {
        a = 9;
        b = 9;
        return a + b;
    }

    //Pass By Output Parameters
    public void My(out int x)
    {
        x = 20;
    }


    public static void ShowPerson(string name, int age, params string[] Childs)
    {
        Console.WriteLine(name + " " + age);
        foreach (var item in Childs)
        {
            Console.WriteLine(item);
        }
    }
}


