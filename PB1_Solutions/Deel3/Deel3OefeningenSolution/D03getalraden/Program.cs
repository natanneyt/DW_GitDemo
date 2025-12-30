namespace D03getalraden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De computer denkt aan een getal tussen 1 en 10.\nWelk getal denkt u dat het is?");
            int gok = int.Parse(Console.ReadLine());
            Random random = new Random();
            int randomGetal = random.Next(0, 11);

            if (gok == randomGetal) Console.WriteLine("Proficiat, u heeft goed geraden!");
            else Console.WriteLine($"Helaas, het getal was {randomGetal}");
        }
    }
}
