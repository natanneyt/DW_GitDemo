namespace D14Pennenzak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pennenzak pennenzak = new Pennenzak("blauw", 35, true);
            Console.WriteLine($"{pennenzak.VraagKleur()}, {pennenzak.IsOpen}");

            pennenzak.SluitPennenzak();
            Console.WriteLine($"{pennenzak.VraagKleur()}, {pennenzak.IsOpen}");

            pennenzak.OpenPennenzak();
            Console.WriteLine($"{pennenzak.VraagKleur()}, {pennenzak.IsOpen}");
        }
    }
}
