//

class Progrme
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.name = "Sina";

        Person person2 = new Person();
        person2.name = "Reza";

        Person person3 = new Person();
        person3.name = "Ali";

        Console.WriteLine(person.ToString());
        Console.WriteLine(person2.ToString());
        Console.WriteLine(person3.ToString());

        Console.WriteLine(Person.SayHello("Sina"));
        Console.WriteLine(People.Sum(3,6));
        
    }
}

class Person
{
    public string name;

    public string gender = "Man";

    public override string ToString()
    {
        return this.name + ":" + gender;
    }

    public static string SayHello(string name)
    {
        return "Hello" + " " + name;
    }

}
public static class People
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}