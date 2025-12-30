namespace D05wildebertram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int oudsteGetal = 0;
                int vorigGetal = 1;
                int getal = 0;
                Console.Write("Aantal maanden groei? ");
                int maanden = int.Parse(Console.ReadLine());
                int huidigeIteratie = 1;

                do
                {
                    getal = oudsteGetal + vorigGetal;
                    oudsteGetal = vorigGetal;
                    vorigGetal = getal;
                    huidigeIteratie++;
                } while (huidigeIteratie < maanden);

                Console.WriteLine($"Aantal knooppunten: {getal}");
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
