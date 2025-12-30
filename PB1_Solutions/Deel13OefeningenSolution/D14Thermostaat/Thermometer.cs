namespace D14Thermostaat
{
    internal class Thermometer
    {
        public double Temperatuur { get; private set; }

        public Thermometer(double temperatuur)
        {
            Temperatuur = temperatuur;
        }

        public void BewerkTemperatuur(double verschil)
        {
            Temperatuur += verschil;
        }
    }
}
