namespace D09aantalkarakters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] woorden = { "dit", "zijn", "een", "aantal", "woorden" };
            int[] aantalKarakters = new int[woorden.Length];
            int voorbijeKarakters = 0;

            foreach(string woord in woorden)
            {
                int woordlengte = woord.Length;
                voorbijeKarakters += woordlengte;
                aantalKarakters[Array.IndexOf(woorden, woord)] = voorbijeKarakters;
            }

            Console.WriteLine(string.Join(',', aantalKarakters));
        }
    }
}
