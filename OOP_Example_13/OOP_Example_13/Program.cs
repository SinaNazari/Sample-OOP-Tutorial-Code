class Program
{
    static void Main(string[] args)
    {
    }
}

class Person
{
    private int id;
    protected string? phone;
    public string? Name;

    public void Send()
    {
        phone = "098655474";
    }
}

class Employees : Person
{
    public string GetPhone()
    {
        return phone;
    }
}