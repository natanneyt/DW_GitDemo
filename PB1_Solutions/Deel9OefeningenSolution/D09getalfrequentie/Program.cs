namespace D09getalfrequentie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hoeveelheden = new int[11];
            int minGetal = 0;
            int maxGetal = 10;
            do
            {
                Console.Write($"Geef een getal tussen [{minGetal},{maxGetal}] in: ");
                string input = Console.ReadLine().ToLower().Trim();
                int huidigGetal = 0;
                if (input == "stop") break;
                else huidigGetal = int.Parse(input);

                if (huidigGetal >= 0 && huidigGetal <= 10)
                    hoeveelheden[huidigGetal]++;
            } while (true);

            for (int i = 0; i <  hoeveelheden.Length; i++)
            {
                if (hoeveelheden[i] != 0) Console.WriteLine($"{i} kwam {hoeveelheden[i]} keer voor.");
            }
        }
    }
}
