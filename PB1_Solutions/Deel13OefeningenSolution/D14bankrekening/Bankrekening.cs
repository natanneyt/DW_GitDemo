namespace D14bankrekening
{
    internal class Bankrekening
    {
        public decimal Saldo { get; private set; }

        public void StortGeld(decimal bedrag)
        {
            if (bedrag < 0) throw new ArgumentException("Bedrag mag niet negatief zijn.");
            else Saldo += bedrag;
        }

        public void HaalGeldAf(decimal bedrag)
        {
            if (bedrag < 0) throw new ArgumentException("Bedrag mag niet negatief zijn.");
            else Saldo -= bedrag;
        }

        public void SchrijfOver(Bankrekening ontvanger, decimal bedrag)
        {
            if (bedrag < 0) throw new ArgumentException("Bedrag mag niet negatief zijn.");
            else
            {
                this.HaalGeldAf(bedrag);
                ontvanger.StortGeld(bedrag);
            }
        }
    }
}
