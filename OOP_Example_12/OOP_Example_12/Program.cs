using OOP_Example_12;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Sina","Nazari");
        Employees employees = new Employees("Sina","Nazari",53000);

        Console.WriteLine($"Name:{person.name} Family:{person.family}");
        Console.WriteLine($"Name:{employees.name} Family:{employees.family} Salary:{employees.salary}");
    }
}