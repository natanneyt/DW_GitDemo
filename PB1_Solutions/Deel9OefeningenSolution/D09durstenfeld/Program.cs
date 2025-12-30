namespace D09durstenfeld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };
            string[] kaarten = new string[52];
            int kaartNummer = 0;
            Random random = new Random();


            foreach (string kleur in kleuren)
            {
                foreach (string waarde in waarden)
                {
                    kaarten[kaartNummer] = $"{kleur} {waarde}";
                    kaartNummer++;
                }
            }
            for (int i = kaarten.Length - 1; i >= 1; i--)
            {
                int randomIndex = random.Next(0, i + 1);
                string tempKaart = kaarten[i];
                kaarten[i] = kaarten[randomIndex];
                kaarten[randomIndex] = tempKaart;
                
            }
            foreach (string kaart in kaarten)
            {
                Console.WriteLine(kaart);
            }
        }
    }
}
