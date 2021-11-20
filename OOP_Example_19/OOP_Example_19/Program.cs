class Program
{
    static void Main(string[] args)
    {
        IAnimal ac = new Cat();
        IAnimal ad = new Dog();

        ac.Speak();
        ad.Speak();

        
        void CheckAge(Person person)
        {
            if (person.Age < 20)
            {
                Console.WriteLine("Your Age Is Low..");
            }
            else
            {
                Console.WriteLine("Your Age is Good..");
            }
        }

        Person p = new Employees();
        p.Age = 15;
        CheckAge(p);
        Employees p2 = new Employees();
        p2.Age = 30;
        CheckAge(p2);
    }
}

interface IAnimal
{
    void Speak();
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Meow..");
    }
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Hap..");
    }
}


class Person
{
    public string Name { get; set; }
    public string Family { get; set; }
    public int Age { get; set; }
}

class Employees : Person
{
    public int Salary { get; set; }
}