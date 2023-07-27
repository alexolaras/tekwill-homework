using Polimorfism;

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Andrei", new DateTime(2020, 01, 05));

        List<string> limbaje = new List<string> {"C#"};
        Programator programator = new Programator("Vasile", new DateTime(2022, 06, 22), limbaje);

        Contabil contabil = new Contabil("Valeria", new DateTime(2021, 02, 01));

        var angajati = new List<Angajat>
        {
            programator, 
            contabil, 
            manager
        };

        angajati.ForEach(angajat => { Console.WriteLine(angajat.CalculeazaSalariu()); });

        programator.AdaugaLimbaj("php");

        angajati.ForEach(angajat => { Console.WriteLine(angajat.CalculeazaSalariu()); });
    }
}