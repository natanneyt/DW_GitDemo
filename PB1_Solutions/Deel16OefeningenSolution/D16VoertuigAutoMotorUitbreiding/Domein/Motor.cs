namespace D16VoertuigAutoMotorUitbreiding.Domein
{
    abstract class Motor
    {
        private double _vermogen;
        public double Vermogen
        {
            get
            {
                return _vermogen;
            }
            set
            {
                if (value < 0) throw new ArgumentException("Het vermogen mag niet negatief zijn.");
                else _vermogen = value;
            }
        }

        public abstract void StartMotor();
    }
}
