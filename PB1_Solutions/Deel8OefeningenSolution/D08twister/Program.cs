namespace D08twister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Het spel start over 3 seconden...");
            Thread.Sleep(3000);
            string[] lichaamsdelen = { "linkerhand", "rechterhand", "linkervoet", "rechtervoet" };
            string[] kleuren = { "rood", "groen", "blauw", "geel" };


            Random rnd = new Random();
            while (true)
            {
                // Kies een willekeurig lichaamsdeel
                int lichaamsdeelNummer = rnd.Next(0, 4);
                string lichaamsdeel = lichaamsdelen[rnd.Next(0,4)];

                // kies een willekeurige kleur
                string kleur = kleuren[rnd.Next(0, 4)];

                // toon de opdracht
                Console.WriteLine($"{lichaamsdeel} op {kleur}");

                // wacht 7 seconden
                System.Threading.Thread.Sleep(7000);
            }
        }
    }
}
