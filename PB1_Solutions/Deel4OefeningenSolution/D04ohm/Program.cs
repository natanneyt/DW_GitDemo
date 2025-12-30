namespace D04ohm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wil je Spanning, Weerstand of Stroomsterkte berekenen?");
            string keuze = Console.ReadLine().ToLower();

            double spanning, weerstand, stroomsterkte;
            // spanning = stroomsterkte x weerstand

            switch(keuze)
            { 
            case "spanning":
            
                Console.Write("Weerstand: ");
                weerstand = double.Parse(Console.ReadLine());
                Console.Write("Stroomsterkte: ");
                stroomsterkte = double.Parse(Console.ReadLine());
                spanning = stroomsterkte * weerstand;
                Console.WriteLine($"De spanning is {spanning}");
                        break;
            case "weerstand":
                Console.Write("Spanning: ");
                spanning = double.Parse(Console.ReadLine());
                Console.Write("Stroomsterkte: ");
                stroomsterkte = double.Parse(Console.ReadLine());
                weerstand = spanning / stroomsterkte;
                Console.WriteLine($"De weerstand is {weerstand}");
                        break;
            case "stroomsterkte":
                Console.Write("Spanning: ");
                spanning = double.Parse(Console.ReadLine());
                Console.Write("Weerstand: ");
                weerstand = double.Parse(Console.ReadLine());
                stroomsterkte = spanning / weerstand;
                Console.WriteLine($"De stroomsterkte is {stroomsterkte}");
                        break;
            default: 
                Console.WriteLine("Ongeldige keuze.");
                break;
            }
        }
    }
}
