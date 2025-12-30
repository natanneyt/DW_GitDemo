namespace D08positieszoekenmooier
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
                    string gevondenIndices = "";
                    Console.Write("Geef een getal in: ");
                    int invoer = int.Parse(Console.ReadLine());

                    for (int i = 0; i < getallen.Length; i++)
                    {
                        if (getallen[i] == invoer)
                        {
                            if (gevondenIndices.Length == 0) gevondenIndices = $"{i}";
                            else gevondenIndices = gevondenIndices + " " + i;
                        }
                    }
                    if (gevondenIndices.Length > 0) Console.WriteLine($"Waarde {invoer} gevonden op plaats(en) {gevondenIndices}.");
                    else Console.WriteLine("Waarde niet gevonden.");
                }
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
