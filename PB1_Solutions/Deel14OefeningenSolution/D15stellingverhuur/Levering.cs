namespace D14stellingverhuur
{
    internal class Levering
    {
        public string Adres { get; set; }

        public int AfstandInKm { get; set; }
        
        public Levering(string adres, int afstandInKm)
        {
            Adres = adres;
            AfstandInKm = afstandInKm;
        }
    }
}
