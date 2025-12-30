using System.Drawing;
using System.Net;

namespace D04patreonsponsor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vanaf 1    Eur: It's a binary buck
            // vanaf 2    Eur: Two's Complement
            // vanaf 3.5  Eur: Nibble - Size
            // vanaf 7    Eur: Glorious 8 - bit simplicity
            // vanaf 14   Eur: 16 - bit is the future
            // vanaf 28   Eur: Cooking with 32 - bits
            // vanaf 55.5 Eur: Commodore 64


            Console.Write("Gedoneerde bedrag: ");
            double gedoneerdeBedrag = double.Parse(Console.ReadLine());

            if (gedoneerdeBedrag < 1) Console.WriteLine("Helaas, voor dat bedrag kan je niet sponsoren.");
            else if (gedoneerdeBedrag >= 1 && gedoneerdeBedrag < 2) Console.WriteLine("Dan word je een \"It's a binary buck\" sponsor.");
            else if (gedoneerdeBedrag >= 2 && gedoneerdeBedrag < 3.5) Console.WriteLine("Dan word je een \"Two's Complement\" sponsor.");
            else if (gedoneerdeBedrag >= 3.5 && gedoneerdeBedrag < 7) Console.WriteLine("Dan word je een \"Nibble - Size\" sponsor.");
            else if (gedoneerdeBedrag >= 7 && gedoneerdeBedrag < 14) Console.WriteLine("Dan word je een \"Glorious 8 - bit simplicity\" sponsor.");
            else if (gedoneerdeBedrag >= 14 && gedoneerdeBedrag < 28) Console.WriteLine("Dan word je een \"16 - bit is the future\" sponsor.");
            else if (gedoneerdeBedrag >= 28 && gedoneerdeBedrag < 55.5) Console.WriteLine("Dan word je een \"Cooking with 32 - bits\" sponsor.");
            else Console.WriteLine("Dan word je een \"Commodore 64\" sponsor.");

        }
    }
}
