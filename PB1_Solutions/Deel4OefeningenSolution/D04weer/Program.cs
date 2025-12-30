using System;

namespace D04weer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Regenboog. (indien het regent en de zon schijnt)
            // Slecht weer. (indien het regent en de zon niet schijnt)
            // Mooi weer. (indien het niet regent en de zon schijnt)
            // Saaie dag. (indien het niet regent en zon niet schijnt)

            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine();
            bool hetRegent = (regen == "ja");

            string weerbeeld = "";
            if (deZonSchijnt == true && hetRegent == true) weerbeeld = "Regenboog";
            else if (deZonSchijnt != true && hetRegent == true) weerbeeld = "Slecht weer";
            else if (deZonSchijnt == true && hetRegent != true) weerbeeld = "Mooi weer";
            else if ((deZonSchijnt == false || hetRegent == false) && deZonSchijnt == hetRegent) weerbeeld = "Saaie dag";
            Console.WriteLine(weerbeeld);
        }
    }
}
