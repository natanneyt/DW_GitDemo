namespace D11getalinput
{
    internal class Program
    {
        static void Main()
        {
            int getal = VraagGetalBinnenBereik(1, 100);
            Console.WriteLine($"U koos voor {getal}");
        }

        static int VraagGetalBinnenBereik(int min, int max)
        {
            while (true)
            {
                Console.Write("Geef een getal van 1 t.e.m. 100 : ");
                try
                {
                    int getal = int.Parse(Console.ReadLine());
                    if (getal >= min && getal < max) return getal;
                    else Console.WriteLine("Het getal moet binnen bereik [1; 100[ liggen. Probeer opnieuw.");
                }
                catch
                {
                    Console.WriteLine("Er liep iets mis. Probeer opnieuw.");
                }
            }
        }
    }
}
