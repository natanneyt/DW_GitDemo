namespace D05reeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Getal 1?: ");
                int grootsteGetal = int.Parse(Console.ReadLine());

                Console.Write("Getal 2?: ");
                int kleinsteGetal = int.Parse(Console.ReadLine());

                if (kleinsteGetal > grootsteGetal)
                {
                    int temp = grootsteGetal;
                    grootsteGetal = kleinsteGetal;
                    kleinsteGetal = temp;
                }

                int huidigGetal = kleinsteGetal;
                do
                {
                    Console.Write($"{huidigGetal} ");
                    huidigGetal++;
                } while (huidigGetal <= grootsteGetal);

            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
