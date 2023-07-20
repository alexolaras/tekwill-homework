using Inheritance2;

class Program
{
    public static void Main(string[] args)
    {
        Mamifer mamifer = new Mamifer()
        {
            Nume = "Cangur Andrei",
            CuloareBlana = "Cafenie"
        };
        Pasare pasare = new Pasare()
        {
            Nume = "Vrabie Veronica",
            TipZbor = "Altitudine joasa"
        };
        Papagal papagal = new Papagal()
        {
            Nume = "Papagal Vasile",
            TipZbor = "Altitudine medie",
            Vocabular = "Englez"
        };

        mamifer.AfisareDetalii();
        Console.WriteLine();

        pasare.AfisareDetalii();
        Console.WriteLine();

        papagal.AfisareDetalii();
    }
}