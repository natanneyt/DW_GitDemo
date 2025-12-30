namespace D09speelkaarten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };
            string[] kaarten = new string[52];
            int kaartNummer = 0;

            foreach(string kleur in kleuren)
            {
                foreach (string waarde in waarden)
                {
                    kaarten[kaartNummer] = $"{kleur} {waarde}";
                    kaartNummer++;
                }
            }

            foreach (string kaart in kaarten)
                Console.WriteLine(kaart);
        }
    }
}
