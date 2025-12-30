namespace D15rekeningkantoor
{
    internal class Adres
    {
        public string Straat { get; set; }

        public string Huisnummer { get; set; }

        public string Postcode { get; set; }

        public string Gemeente { get; set; }

        public Adres(string straat, string huisnummer, string postcode, string gemeente)
        {
            Straat = straat;
            Huisnummer = huisnummer;
            Postcode = postcode;
            Gemeente = gemeente;
        }
        
        public override string ToString()
        {
            return $"{Straat} {Huisnummer}, {Postcode} {Gemeente}";
        }
    }
}
