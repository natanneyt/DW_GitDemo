namespace D15Spaarpot
{
    internal class Muntstuk
    {
        private int _waarde;
        public int Waarde
        {
            get
            {
                return _waarde;
            }
            set
            {
                if (value < 0) throw new ArgumentException("De waarde mag niet negatief zijn.");
                else _waarde = value;
            }
        }

        public Muntstuk(int waarde)
        {
            Waarde = waarde;
        }
    }
}
