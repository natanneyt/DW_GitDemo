namespace D14artikel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Artikel artikel = new Artikel(23.98);
            Console.WriteLine($"{artikel.PrijsExclBTW} {artikel.BtwPercentage} {artikel.BerekenBTW()} {artikel.BerekenPrijsInclBTW()}");

            Artikel artikel2 = new Artikel(23.98,3.8);
            Console.WriteLine($"{artikel2.PrijsExclBTW} {artikel2.BtwPercentage} {artikel2.BerekenBTW()} {artikel2.BerekenPrijsInclBTW()}");
        }
    }
}
