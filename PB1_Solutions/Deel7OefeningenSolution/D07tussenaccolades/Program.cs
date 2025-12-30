namespace D07tussenaccolades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een stuk tekst in:");
            string tekst = Console.ReadLine();
            bool isTussenAccolades = false;

            if (tekst.Contains('{') && tekst.Contains('}'))
            {
                Console.Write("Gevonden: ");
                for (int i = 0; i < tekst.Length; i++)
                {
                    if (tekst[i] == '}')
                    {
                        isTussenAccolades = false;
                        break;
                    }
                    if (isTussenAccolades) Console.Write(tekst[i]);
                    if (tekst[i] == '{') isTussenAccolades = true;
                }
            } else Console.WriteLine("Niets gevonden.");
        }
    }
}
