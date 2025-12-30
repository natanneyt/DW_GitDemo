namespace D07bevatleesteken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst:");
            string tekst = Console.ReadLine();
            bool bevatLeesteken = false;

            foreach (char c in tekst)
            {
                if (Char.IsPunctuation(c)) bevatLeesteken = true;
            }
            if (bevatLeesteken) Console.WriteLine("De tekst bevat minstens 1 leesteken.");
            else Console.WriteLine("De tekst bevat geen enkel leesteken.");
                    
        }
    }
}
