namespace D02frietjes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geef een naam: Jan
            //Geef nog een naam: Mieke
            //Geef een gerecht : frietjes
            //Jan en Mieke eten graag frietjes.
            Console.WriteLine("Geef een naam.");
            string naam1 = Console.ReadLine();
            Console.WriteLine("Geef nog een naam.");
            string naam2 = Console.ReadLine();
            Console.WriteLine("Geef een gerecht.");
            string gerecht = Console.ReadLine();
            Console.WriteLine(naam1 + " en " + naam2 + " eten graag " + gerecht + ".");

        }
    }
}
