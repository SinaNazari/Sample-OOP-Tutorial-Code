class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Age = 22;
        CheckAge(p);

        Person p2 = new Employees();
        p2.Age = 12;
        CheckAge(p2);

        Person p3 = new Faculty();
        p3.Age = 33;
        CheckAge(p3);

        void CheckAge(Person person)
        {
            if (person is Employees)
            {
                Console.WriteLine("Employees");
            }
            else if (person is Faculty)
            {
                Console.WriteLine("Faculty");
            }
            else
            {
                Console.WriteLine("Person");
            }
        }
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
    public double Salary { get; set; }
}

class Faculty : Person
{
    public string Name { get; set; }
}