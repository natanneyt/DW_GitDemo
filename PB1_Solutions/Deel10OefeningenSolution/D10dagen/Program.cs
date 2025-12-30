namespace D10dagen
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                Console.Write("Maand?: ");
                int maand = int.Parse(Console.ReadLine());
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                string[] maanden = {"januari", "februari", "maart", "april", "mei", "juni", "juli",
                        "augustus", "september", "oktober", "november", "december"};
                Console.WriteLine($"In {maanden[maand - 1]} van {jaar} zijn er {AantalDagen(maand, jaar)} dagen.");
                Console.WriteLine();
            } while (true);
        }

        static int AantalDagen(int maand, int jaar)
        {
            if (maand == 2) return AantalDagenInFebruari(jaar);
            else
            {
                if (maand == 1 || maand == 3 || maand == 5 || maand == 7 || maand == 8 || maand == 10 || maand == 12) return 31;
                else return 30;
            }
        }

        static int AantalDagenInFebruari(int jaar)
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
