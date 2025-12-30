namespace D08positieszoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = { 5, 3, 1, -1, -3, 3, 9, -4 };

            try
            {
                while (true)
                {
                    Console.Write("Geef een getal in: ");
                    int invoer = int.Parse(Console.ReadLine());

                    for (int i = 0; i < getallen.Length; i++)
                    {
                        if (getallen[i] == invoer)
                        {
                            Console.Write($"{i} ");
                        }
                    }
                    Console.WriteLine("");
                }
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
