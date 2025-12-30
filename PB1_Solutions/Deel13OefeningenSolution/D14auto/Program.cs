namespace D14auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registratie auto");
            Console.WriteLine("(1) Auto (alles standaard)");
            Console.WriteLine("(2) Auto met gekeuzen kleur");

            List<Auto> autos = new List<Auto>();

            while (true)
            {
                Console.WriteLine("Wens je nog een auto te registreren?");
                string invoer = Console.ReadLine().Trim().ToLower();
                int invoerGetal = 0;


                try
                {
                    invoerGetal = int.Parse(invoer);
                }
                catch
                {
                    Console.WriteLine("Dit was geen correct getal.");
                }

                if (invoerGetal == 1)
                {
                    autos.Add(new Auto());
                }
                else if (invoerGetal == 2)
                {
                    Console.WriteLine($"Welke kleur heeft de auto?");
                    autos.Add(new Auto(Console.ReadLine().Trim().ToLower()));
                }
                else break;
            }

            int aantalGrijzeAutos = 0;
            
            foreach(Auto auto in autos)
            {
                if (auto.Kleur.Equals("grijs"))
                    aantalGrijzeAutos++;
            }
            Console.WriteLine($"Aantal auto's: {autos.Count}, Aantal grijze auto's: {aantalGrijzeAutos}");
        }
    }
}
