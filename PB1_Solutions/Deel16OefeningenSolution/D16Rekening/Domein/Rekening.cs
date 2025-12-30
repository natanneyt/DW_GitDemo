namespace D16Rekening.Domein
{
    abstract class Rekening
    {
        protected double Saldo { get; set; }

        public Rekening(double saldo)
        {
            Saldo = saldo;
        }

        public abstract void HaalAf(double bedrag);
    }
}
