namespace D04weermetrobuusteinvoer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Schijnt de zon (ja/nee)?: ");
            string zon = Console.ReadLine().ToLower().Trim();
            bool deZonSchijnt = (zon == "ja");

            Console.Write("Regent het (ja/nee)?: ");
            string regen = Console.ReadLine().ToLower().Trim();
            bool hetRegent = (regen == "ja");

            string weerbeeld = "";
            if (deZonSchijnt && hetRegent) weerbeeld = "Regenboog";
            else if (!deZonSchijnt && hetRegent) weerbeeld = "Slecht weer";
            else if (deZonSchijnt && !hetRegent) weerbeeld = "Mooi weer";
            else if (!deZonSchijnt && !hetRegent) weerbeeld = "Saaie dag";
            Console.WriteLine(weerbeeld);
        }
    }
}
