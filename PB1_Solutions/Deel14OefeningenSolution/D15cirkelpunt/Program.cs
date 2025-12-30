using D15cirkelpunt.Figuren;

namespace D15cirkelpunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel c = new Cirkel(10, 20, 5);   // x, y en straal
            Punt p1 = new Punt(13, 25); // x en y
            Punt p2 = new Punt(8, 16); // x en y
            
            Console.WriteLine(c.Bevat(p1)); // toont false
            Console.WriteLine(c.Bevat(p2)); // toont true
            
            c.VerplaatsNaar(11, 27); // x en y
            
            Console.WriteLine(c.Middelpunt.X); // toont 11
            Console.WriteLine(c.Middelpunt.Y); // toont 27
            
            Console.WriteLine(c.Bevat(p1)); // toont true
            Console.WriteLine(c.Bevat(p2)); // toont false

            // D15cirkeloverlapt
            Cirkel c1 = new Cirkel(10, 20, 5);
            Cirkel c2 = new Cirkel(8, 12, 10);
            Cirkel c3 = new Cirkel(100, 200, 3);
            
            Console.WriteLine(c1.Overlapt(c2));  // moet true opleveren
            Console.WriteLine(c2.Overlapt(c3));  // moet false opleveren
        }
    }
}