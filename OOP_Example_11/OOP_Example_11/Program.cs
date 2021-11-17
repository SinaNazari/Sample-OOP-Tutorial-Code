using OOP_Example_11;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student()
        {
            Id = 1,
            FirstName = "Sina",
            LastName = "Nazari",
            Email = "Sina@gmail.com",
            Age = 20,
            UniversityName = "*****",
            UniversityLocation = "Iran",
            UniversituRank = 67
        };
        
        Employees employees = new Employees()
        {
            Id = 9867,
            FirstName = "Ali",
            LastName = "Nazari",
            Email = "Ali@gmail.com",
            Age = 30,
            CompanyName = "IranRack",
            CompanyLocation = "Iran-Tehran",
            Salary = 30000,
        };

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Student:Id= {student.Id} FirstName= {student.FirstName} LastName = {student.LastName} Email= {student.Email} Age={student.Age} UniversityName= {student.UniversityName}" +
            $"UniversityLocation = {student.UniversityLocation} UniversityRank = {student.UniversituRank}");
        Console.ResetColor();

        Console.WriteLine("////");
        Console.WriteLine("///");
        Console.WriteLine("//");
        Console.WriteLine("/");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Employees: Id= {employees.Id}FirstName ={employees.FirstName} LastName = {employees.LastName} Email= {employees.Email} Age= {employees.Age} CompanyName ={employees.CompanyName}" +
            $"CompanyLocation = {employees.CompanyLocation} Salary= {employees.Salary}");
        Console.ResetColor();
        
    }
    
}
