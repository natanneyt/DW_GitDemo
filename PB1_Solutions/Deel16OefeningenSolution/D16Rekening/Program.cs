using D16Rekening.Domein;

namespace D16Rekening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rekening> rekeningen = new List<Rekening>();

            rekeningen.Add(new Zichtrekening(24));
            rekeningen.Add(new Spaarrekening(234));
            rekeningen.Add(new Zichtrekening(322));
            rekeningen.Add(new Spaarrekening(2445));
            rekeningen.Add(new Zichtrekening(2334));

            int counter = -1;
            do
            {
                try
                {
                    counter++;
                    Console.Write($"{rekeningen[counter]}: ");
                    rekeningen[counter].HaalAf(250);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (counter + 1 < rekeningen.Count);
        }
    }
}
