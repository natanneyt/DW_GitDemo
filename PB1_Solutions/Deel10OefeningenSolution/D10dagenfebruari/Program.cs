namespace D10dagenfebruari
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                Console.WriteLine($"In februari van {jaar} zijn er {AantalDagen(jaar)} dagen.");
                Console.WriteLine();
            } while (true);
        }

        static int AantalDagen(int jaar)
        {
            int aantalDagen = 0;
            if (IsSchrikkeljaar(jaar)) aantalDagen = 29;
            else aantalDagen = 28;
            return aantalDagen;
        }

        static bool IsSchrikkeljaar(int jaartal)
        {
            return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
        }

    }
}
