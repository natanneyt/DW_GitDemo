namespace D04grootste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Getal 2: ");
            int getal2 = int.Parse(Console.ReadLine());

            Console.Write("Getal 3: ");
            int getal3 = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Het grootste getal is {Math.Max(Math.Max(getal1, getal2)}");

            // !1! 2 3 GEDAAN
            // 1 !2! 3 GEDAAN
            // 1 2 !3! GEDAAN
            // 1=2 3
            // 1 2=3 GEDAAN
            // 1=3 2 GEDAAN
            // 1=2=3 GEDAAN

            if (getal1 == getal2 && getal2 == getal3) Console.WriteLine($"De drie getallen zijn even groot: {getal1}");
            else if (getal1 > getal2 && getal1 != getal3)
            {
                if (getal1 > getal3) Console.WriteLine($"Het grootste getal is getal 1: {getal1}");
                else Console.WriteLine($"Het grootste getal is getal 3: {getal3}");
            }
            else if (getal1 > getal2 && getal1 == getal3) Console.WriteLine($"Getallen 1 en 3 zijn de grootste: {getal1}");
            else if (getal2 > getal1 && getal2 != getal3)
            {
                if (getal2 > getal3) Console.WriteLine($"Het grootste getal is getal 2: {getal2}");
                else Console.WriteLine($"Het grootste getal is getal 3: {getal3}");
            }
            else if (getal2 > getal1 && getal2 == getal3) Console.WriteLine($"Getallen 2 en 3 zijn de grootste: {getal2}");
            else Console.WriteLine($"Getallen 1 en 2 zijn de grootste: {getal1}");
        }
    }
}
