namespace D16Dieren.Domein
{
    internal class Duif : Dier
    {
        private int _ringnummer;
        public int Ringnummer
        {
            get
            {
                return _ringnummer;
            }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Ringnummer moet positief zijn.");
                else _ringnummer = value;
            }
        }
        
        public Duif(string naam, int ringnummer) : base(naam)
        {
            Ringnummer = ringnummer;
        }

        public override void GeefInfo()
        {
            base.GeefInfo();
            Console.Write($", {Ringnummer}.\n");
        }

    }
}
