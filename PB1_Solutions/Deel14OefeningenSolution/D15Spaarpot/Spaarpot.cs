namespace D15Spaarpot
{
    internal class Spaarpot
    {
        public List<Muntstuk> Muntstukken { get; private set; } = new List<Muntstuk>();

        public Spaarpot() { }

        public void VoegMuntstukToe(Muntstuk muntstuk)
        {
            Muntstukken.Add(muntstuk);
        }

        public double GeefTotaalbedrag()
        {
            double totaalbedrag = 0;

            foreach(Muntstuk ms in Muntstukken)
            {
                totaalbedrag += (ms.Waarde / 100.0);
            }
            return totaalbedrag;
        }
    }
}
