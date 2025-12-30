using System;
namespace D14bankrekening
{
    class Program
    {
        static void Main()
        {
            Bankrekening b1 = new Bankrekening();
            Bankrekening b2 = new Bankrekening();
            decimal bedrag = 100m;

            b1.SchrijfOver(b2, 100m);

            Console.WriteLine(b1.Saldo == -100m); // zou true moeten geven
            Console.WriteLine(b2.Saldo == 100m);  // zou true moeten geven
        }
    }
}
 