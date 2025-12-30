namespace D14Persoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoon persoon1 = new Persoon("Jan", new DateTime(2012, 12, 31), "Gent");
            Console.WriteLine($"{persoon1.Naam}, {persoon1.Geboortedatum.ToString("dd/MM/yyyy")}, {persoon1.Woonplaats}");

            try
            {
                Persoon persoon2 = new Persoon("Bart", new DateTime(2026, 12, 31), "Gent");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Er liep iets fout: {ex.Message}");
            }
            persoon1.Naam = "Wim";
            persoon1.Geboortedatum = new DateTime(2021, 2, 23);
            persoon1.Woonplaats = "Brussel";
            Console.WriteLine($"{persoon1.Naam}, {persoon1.Geboortedatum.ToString("dd/MM/yyyy")}, {persoon1.Woonplaats}");

        }
    }
}
