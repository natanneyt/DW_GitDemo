namespace D09maximumtemperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] meetwaarden = { 13.4, 12.1, 10.8, 10.8, 10.3, 8.9, 7.9, 7.8, 7.4, 7.2, 6.4, 9.7, 13.7, 17.2, 19.6, -9999.0, -9999.0, 22.4, 22.7, 22.8, 22.3, 18.4 };
            double minWaarde = 0;
            double maxWaarde = 0;
            bool waardeGevonden = false;

            foreach(double d in meetwaarden)
            {
                if (d != -9999)
                {
                    if (Array.IndexOf(meetwaarden, d) == 0) 
                    { 
                        minWaarde = d;
                        maxWaarde = d;
                        waardeGevonden = true;
                    }
                    else if (d > maxWaarde) maxWaarde = d;
                    else if (d < minWaarde) minWaarde = d;
                }
            }
            if (!waardeGevonden) Console.WriteLine("Geen waarden gevonden");

            else if (meetwaarden.Length != 0) Console.WriteLine($"Minimumwaarde: {minWaarde}, Maximumwaarde: {maxWaarde}");
        }
    }
}
