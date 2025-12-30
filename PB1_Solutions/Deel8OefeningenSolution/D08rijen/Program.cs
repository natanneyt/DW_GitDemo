namespace D08rijen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxAantalGetallen = 6;
            int aantalGetallen = 0;
            int[] getallen = new int[maxAantalGetallen];
            int verschil = 0;
            int factor = 0;
            bool isRekenkundig = true;
            bool isVeelvoudig = true;

            try
            {
                for (int i = 0; i < maxAantalGetallen; i++)
                {
                    Console.Write("Geef een getal in: ");
                    string invoer = Console.ReadLine();
                    if (invoer != "")
                    {
                        getallen[i] = int.Parse(invoer);
                        aantalGetallen++;
                    }
                }

                verschil = getallen[aantalGetallen -1] - getallen[aantalGetallen - 2];
                factor = getallen[aantalGetallen - 1] / getallen[aantalGetallen - 2];

                for (int i = aantalGetallen - 1; i >= 0; i--)
                {
                    if (i != 0)
                    {
                        if (getallen[i] - getallen[i - 1] != verschil) isRekenkundig = false;
                        if (getallen[i] / getallen[i - 1] != factor) isVeelvoudig = false;
                    }
                }
                if (isRekenkundig) Console.WriteLine($"Dit is een rekenkundige rij met delta {verschil}.");
                else if (isVeelvoudig) Console.WriteLine($"Dit is een veelvoudige rij met factor {factor}.");
                else Console.WriteLine("Dit is een gewone rij.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }
        }
    }
}
