using System.ComponentModel.Design;

namespace D12gemeenteraad
{
    class Program
    {
        static void Main()
        {
            // Voor fictieve gemeente X:
            int inwonersGemeente = 125;
            int[] lijstNummers = { 1, 2, 3, 4 };
            string[] lijsten = { "Groen", "Open Vld", "N-VA", "sp.a" };
            int[] stemcijfers = { 60, 30, 31, 4 };

            // Voor Gent (gemeenteraadsverkiezingen 2018): 
            // (vervang bovenstaande regels door onderstaande om voor deze gemeente uit te testen)

            //int inwonersGemeente = 259570;
            //int[] lijstNummers = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //string[] lijsten = { "spa.a-Groen", "N-VA", "CD&V", "VLAAMS BELANG", "Open Vld", "PVDA", "DUW.GENT", "MRP", "SPIEGEL Partij", "BE-ONE", "GENTSE BURGERS", "VMC", "PISS-OFF" };
            //int[] stemcijfers = { 53179, 19167, 13979, 12354, 39879, 11178, 3229, 498, 329, 1709, 1633, 480, 931 };
            

            // Vraag het aantal raadsleden voor de gemeenteraad op:
            int raadsleden = Raadsleden(inwonersGemeente);

            // Vraag het aantal zetels (voor elke lijst) op:
            int[] zetels = Zetels(raadsleden, lijsten, stemcijfers);

            Print(lijstNummers, lijsten, stemcijfers, zetels);
        }

        static int Raadsleden(int inwoners)
        {
            int minimumRaadsleden = 7;
            int[] inwonersAantallen = { 1000, 2000, 3000, 4000, 5000, 7000, 9000, 12000, 15000,
                            20000, 25000, 30000, 35000, 40000, 50000, 60000, 70000,
                            80000, 90000, 100000, 150000, 200000, 250000, 300000 };
            int[] raadsledenAantallen = { 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35,
                              37, 39, 41, 43, 45, 47, 49, 51, 53, 55 };

            for (int i = 0; i < inwonersAantallen.Length; i++)
            {
                if (i == 0 && inwoners < inwonersAantallen[0]) return minimumRaadsleden;
                else if (i == inwonersAantallen.Length - 1) return raadsledenAantallen[i];
                else if (inwoners > inwonersAantallen[i] && inwoners < inwonersAantallen[i + 1]) return raadsledenAantallen[i];
            }
            return 7;
        }

        static int[] Zetels(int raadsleden, string[] lijsten, int[] stemcijfers)
        {
            int[] zetels = new int[stemcijfers.Length];
            double[] aangepasteStemcijfers = new double[stemcijfers.Length];

            for (int i = 0; i < stemcijfers.Length; i++)
            {
                aangepasteStemcijfers[i] = stemcijfers[i];
            }
            for (int r = 0; r < raadsleden; r++)
            {
                int grootsteGetalIndex = 0;
                double grootsteGetal = aangepasteStemcijfers[grootsteGetalIndex];
                for (int i = 0; i < stemcijfers.Length; i++)
                {
                    if (grootsteGetal < aangepasteStemcijfers[i])
                    {
                        grootsteGetalIndex = i;
                        grootsteGetal = aangepasteStemcijfers[i];
                    }
                    else if (grootsteGetal == aangepasteStemcijfers[i])
                    {
                        if (stemcijfers[i] >= stemcijfers[grootsteGetalIndex])
                        {
                            grootsteGetalIndex = i;
                            grootsteGetal = aangepasteStemcijfers[i];
                        }
                    }
                }
                zetels[grootsteGetalIndex]++;

                aangepasteStemcijfers[grootsteGetalIndex] = aangepasteStemcijfers[grootsteGetalIndex] - (aangepasteStemcijfers[grootsteGetalIndex] / (zetels[grootsteGetalIndex] + 1));
            }
            return zetels;
        }

        static void Print(int[] lijstNummers, string[] lijsten, int[] stemcijfers, int[] zetels)
        {
            for (int i = 0; i < lijstNummers.Length; i++)
            {
                Console.WriteLine($"{lijstNummers[i],2}: {lijsten[i],15:d}: {zetels[i],2:d} zetels: {stemcijfers[i],6:d} stemmen");
            }
        }
    }
}
