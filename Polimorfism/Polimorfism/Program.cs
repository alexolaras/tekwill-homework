using Polimorfism;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Andrei", new DateTime(2020, 01, 05));

        List<string> languages = new List<string> {"C#"};
        Programmer programmer = new Programmer("Vasile", new DateTime(2022, 06, 22), languages);

        Accountant accountant = new Accountant("Valeria", new DateTime(2021, 02, 01));

        var employees = new List<Employee>
        {
            programmer, 
            accountant, 
            manager
        };

        employees.ForEach(angajat => Console.WriteLine(angajat.CalculateSalary());

        programmer.AddLanguage("php");

        employees.ForEach(angajat => Console.WriteLine(angajat.CalculateSalary());
    }
}