namespace D04dagnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // De maanden van het jaar zijn: januari(31), februari(28 / 29), maart(31), april(30), mei(31), juni(30), juli(31), augustus(31), september(30), oktober(31), november(30) en december(31).

            Console.Write("Dag van het jaar: ");
            int dag = int.Parse(Console.ReadLine());
            string maand = "n/a";

            // januari = 1-31
            if (dag >= 1 && dag <= 31) maand = "Januari";

            // februari = 32-60
            else if (dag >= 32 && dag <= 60) maand = "Februari";

            // maart = 61-91
            else if (dag >= 61 && dag <= 91) maand = "Maart";

            // april = 92-121
            else if (dag >= 92 && dag <= 121) maand = "April";

            // mei = 122-152
            else if (dag >= 122 && dag <= 152) maand = "Mei";

            // juni = 153-182
            else if (dag >= 153 && dag <= 182) maand = "Juni";

            // juli = 183-213
            else if (dag >= 183 && dag <= 213) maand = "Juli";

            // augustus = 214-244
            else if (dag >= 214 && dag <= 244) maand = "Augustus";

            // september = 245-273
            else if (dag >= 245 && dag <= 273) maand = "September";

            // oktober = 274-304
            else if (dag >= 274 && dag <= 304) maand = "Oktober";

            // november = 305-334
            else if (dag >= 305 && dag <= 334) maand = "November";

            // december = 335-365
            else if (dag >= 335 && dag <= 365) maand = "December";

            Console.WriteLine($"Deze dag hoort bij de maand {maand}");
        }
    }
}
