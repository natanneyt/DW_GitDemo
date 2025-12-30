namespace D11geenscheldwoordenarray
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Geef een tekst : ");
            string tekst = Console.ReadLine();

            bool isOk = IsAanvaardbaar(tekst);

            if (isOk)
            {
                Console.WriteLine("Tekst is aanvaardbaar");
            }
            else
            {
                Console.WriteLine("Tekst is niet aanvaardbaar");
            }
        }

        static bool IsAanvaardbaar(string tekst)
        {
            string[] scheldwoorden = { "een", "twee", "drie" }; // gecensureerd op aanraden van mijn moeder

            foreach (string scheldwoord in scheldwoorden)
            {
                if (tekst.Contains(scheldwoord))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
