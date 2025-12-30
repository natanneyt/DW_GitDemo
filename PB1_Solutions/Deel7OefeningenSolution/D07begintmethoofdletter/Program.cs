namespace D07begintmethoofdletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine();
            bool startMetHoofdletter = false;

            if (Char.IsUpper(tekst[0])) startMetHoofdletter = true;
            if (startMetHoofdletter) Console.WriteLine("De tekst start met een hoofdletter.");
            else Console.WriteLine("De tekst start met een kleine letter.");
        }
    }
}
