
namespace D11kader
{
    internal class Program
    {
        static void Main()
        {
            int kaderbreedte = 1;
            ToonInKader("Hallo", kaderbreedte);
        }

        static void ToonInKader(string tekst, int breedte)
        {
            for (int i = 0; i < breedte; i++) TekenLijn(tekst.Length + 2 * breedte + 2);
            for (int i = 0; i < breedte; i++) Console.Write("*");
            Console.Write($" {tekst} ");
            for (int i = 0; i < breedte; i++) Console.Write("*");
            Console.WriteLine("");
            for (int i = 0; i < breedte; i++) TekenLijn(tekst.Length + 2 * breedte + 2);
        }

        static void TekenLijn(int lengte)
        {
            for (int i = 0; i < lengte; i++) 
                Console.Write("*"); 
            Console.WriteLine("");
        }
    }
}
