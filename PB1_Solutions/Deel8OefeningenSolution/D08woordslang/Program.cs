namespace D08woordslang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] woorden = new string[5];
            int aantalWoorden = 5;
            string[] fouteWoorden = new string[2];

            for (int i = 0; i < aantalWoorden; i++)
            {
                Console.WriteLine("Geef een woord: ");
                woorden[i] = Console.ReadLine().ToLower().Trim();
            }

            for (int i = 0; i < woorden.Length; i++)
            {
                if (i > 0)
                {
                    if (woorden[i][0] != woorden[i - 1][woorden[i - 1].Length - 1])
                    {
                        fouteWoorden[0] = woorden[i - 1];
                        fouteWoorden[1] = woorden[i];
                        break;
                    }
                }
                else if (i < woorden.Length - 1)
                {
                    if (woorden[i][woorden[i].Length - 1] != woorden[i + 1][0])
                    {
                        fouteWoorden[0] = woorden[i];
                        fouteWoorden[1] = woorden[i + 1];
                        break;
                    }
                }
            }
            if (fouteWoorden[0] != null) Console.WriteLine($"Het is geen woordslang: {fouteWoorden[0]}-{fouteWoorden[1]}");
            else Console.WriteLine($"De woordslang is {woorden[0]}-{woorden[1]}-{woorden[2]}-{woorden[3]}-{woorden[4]}");
        }
    }
}
