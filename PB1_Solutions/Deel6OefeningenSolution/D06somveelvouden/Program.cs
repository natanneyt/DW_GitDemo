namespace D06somveelvouden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Geef een eerste getal: ");
                int kleinerGetal = int.Parse(Console.ReadLine());

                Console.Write("Geef een groter getal: ");
                int groterGetal = int.Parse(Console.ReadLine());
                int som = 0;

                for(int i = kleinerGetal; i <= groterGetal; i++)
                {
                    if (i % 3 == 0 | i % 5 == 0) som += i;
                }

                Console.WriteLine(som);
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
