namespace D12periodeoverlapt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opvragen start- en einddatum van periode 1...
            DateTime datum1 = Datum("startdatum van periode 1");
            DateTime datum2 = DatumVanaf(datum1, "einddatum van periode 1");

            // Opvragen start- en einddatum van periode 2...
            DateTime datum3 = Datum("startdatum van periode 2");
            DateTime datum4 = DatumVanaf(datum3, "einddatum van periode 2");

            // Controleren of deze periodes overlappen...
            string overlappen = "overlappen";
            if (!Overlapt(datum1, datum2, datum3, datum4)) overlappen += " niet";

            // Printen van de output...
            Console.Write($"Periode 1 ({PeriodeLabel(datum1, datum2)}) en periode 2 ({PeriodeLabel(datum3, datum4)}) {overlappen}.");
        }

        static DateTime Datum(string omschrijving)
        {
            return DatumVanaf(DateTime.MinValue, omschrijving);
        }

        static DateTime DatumVanaf(DateTime minimumDatum, string label)
        {
            do
            {
                try
                {
                    Console.Write($"{label}: ");
                    DateTime invoerDatum = DateTime.Parse(Console.ReadLine());
                    if (minimumDatum < invoerDatum)
                    {
                        return invoerDatum;
                    }    
                }
                catch
                {
                    Console.WriteLine("Ongeldige datum");
                }

            } while (true);
        }

        static bool Overlapt(DateTime datum1, DateTime datum2, DateTime datum3, DateTime datum4)
        {
            if ((datum1 < datum3 && datum2 < datum3) || (datum3 < datum1 && datum4 < datum1)) return false;
            else return true;
        }

        static string PeriodeLabel(DateTime datum1, DateTime datum2)
        {
            return $"{datum1.ToString("dd/MM/yyyy")} - {datum2.ToString("dd/MM/yyyy")}";
        }




    }
}
