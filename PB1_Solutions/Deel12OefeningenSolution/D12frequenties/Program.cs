namespace D12frequenties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aantal = 10;
            int[] getallen = VraagGetallen(aantal);
            int som = BerekenSom(getallen);
            Console.WriteLine(som);
            Console.WriteLine(BerekenGemiddelde(som, aantal));
            ToonFrequenties(getallen);
        }

        static int[] VraagGetallen(int aantal)
        {
            int[] getallen = new int[aantal];
            for(int i = 0; i < aantal; i++)
            {
                try
                {
                    Console.Write($"Getal {i + 1}: ");
                    getallen[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dit is geen geldig getal.");
                    i--;
                }
            }
            return getallen;
        }

        static int BerekenSom(int[] getallen)
        {
            int som = 0;
            foreach(int getal in getallen)
            {
                som += getal;
            }
            return som;
        }

        static int BerekenGemiddelde(int som, int aantal)
        {
            return som / aantal;
        }

        static void ToonFrequenties(int[] getallen)
        {
            int[] dubbels = new int[getallen.Length];
            int aantalDubbels = 0;
            foreach (int getal in getallen)
            {
                foreach (int anderGetal in getallen)
                {
                    if (getal == anderGetal)
                    {
                        if (!dubbels.Contains(getal))
                        {
                            dubbels[aantalDubbels] = getal;
                            aantalDubbels++;
                        }
                    }
                }
            }

            foreach (int dubbelGetal in dubbels)
            {
                int aantal = 0;
                foreach(int getal in getallen)
                {
                    if (dubbelGetal == getal) aantal++;
                }
                if (aantal > 1) Console.WriteLine($"Het getal {dubbelGetal} komt {aantal} keer voor.");
            }
        }
    }
}
