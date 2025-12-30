namespace D14cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel(3.45);

            Console.WriteLine($"{cirkel.Straal}, {cirkel.BerekenOmtrek()}, {cirkel.BerekenOppervlakte()}");

            try
            {
                cirkel.Straal = -0.3;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Er is iets misgelopen: {ex.Message}");
            }
        }
    }
}
