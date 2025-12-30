namespace D15rekeningkantoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adres adres1 = new Adres("Koekoekstraat", "70", "9090", "Melle");
            Persoon persoon1 = new Persoon("Jan", "Janssens", adres1);
            Adres adres2 = new Adres("Kerkstraat", "12", "8000", "Brugge");
            Persoon persoon2 = new Persoon("Mieke", "Mickelsen", adres2);
            Kantoor kantoor1 = new Kantoor(persoon2, adres2);
            Rekening rekening1 = new Rekening("BE11 2222 3333 4444", 120, kantoor1, persoon1);

            Console.WriteLine(string.Join(", ",persoon1.Voornaam, persoon1.Achternaam, persoon1.Adres.ToString()));
            Console.WriteLine($"{rekening1.Titularis.Voornaam} heeft een rekening met nummer {rekening1.Nummer} met daarop {rekening1.Saldo}EUR");
            Console.WriteLine($"Deze rekening is bij het kantoor van {rekening1.Kantoor.Kantoorhouder.Voornaam} {rekening1.Kantoor.Kantoorhouder.Achternaam}, {rekening1.Kantoor.Adres.ToString()}");
            if (rekening1.Kantoor.Adres == rekening1.Kantoor.Kantoorhouder.Adres) Console.WriteLine($"{rekening1.Kantoor.Kantoorhouder.Voornaam} woont in haar kantoor");

            persoon2.Adres = new Adres(adres2.Straat, "99", adres2.Postcode, adres2.Gemeente);

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", persoon1.Voornaam, persoon1.Achternaam, persoon1.Adres.ToString()));
            Console.WriteLine($"{rekening1.Titularis.Voornaam} heeft een rekening met nummer {rekening1.Nummer} met daarop {rekening1.Saldo}EUR");
            Console.WriteLine($"Deze rekening is bij het kantoor van {rekening1.Kantoor.Kantoorhouder.Voornaam} {rekening1.Kantoor.Kantoorhouder.Achternaam}, {rekening1.Kantoor.Adres.ToString()}");
            if (rekening1.Kantoor.Adres == rekening1.Kantoor.Kantoorhouder.Adres) Console.WriteLine($"{rekening1.Kantoor.Kantoorhouder.Voornaam} woont in het kantoor");
            else Console.WriteLine($"{rekening1.Kantoor.Kantoorhouder.Voornaam} woont niet in het kantoor.");
        }
    }
}
