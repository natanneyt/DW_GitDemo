using D19persoonopleeftijd.Domein;

namespace D19persoonopleeftijd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persoon> personen = new List<Persoon>();
            personen.Add(new Persoon("Jan", 23));
            personen.Add(new Persoon("Miet", 45));
            personen.Add(new Persoon("Joris", 34));
            personen.Add(new Persoon("Corneel", 12));
            personen.Add(new Persoon("Phara", 34));

            PrintPersonenMetTitel("ongesorteerd", personen);
            personen.Sort(new PersoonNaamComparerSlim());
            PrintPersonenMetTitel("gesorteerd op naam a->z", personen);
            personen.Sort(new PersoonNaamComparerSlim(false));
            PrintPersonenMetTitel("gesorteerd op naam z->a", personen);

            //PrintPersonenMetTitel("gesorteerd op leeftijd", personen);
            //personen.Sort(new PersoonNaamComparer());
            //PrintPersonenMetTitel("gesorteerd op naam", personen);
            //personen.Sort(new PersoonNaamComparer());
            //PrintPersonenMetTitel("nogmaals gesorteerd op naam", personen);
        }
        static void PrintPersonenMetTitel(string titel, List<Persoon> personen)
        {
            Console.WriteLine($"--- {titel} ---");
            foreach(Persoon persoon in personen)
            {
                Console.WriteLine(persoon);
            }
        }
    }
}
