namespace D16Rekening.Domein
{
    internal class Spaarrekening : Rekening
    {
        public Spaarrekening(double saldo) : base(saldo) { }
        public override void HaalAf(double bedrag)
        {
            if (Saldo - bedrag < 0) throw new ArgumentException("Het saldo mag niet negatief zijn.");
            else Saldo -= bedrag;
            Console.WriteLine($"Nieuw saldo: {Saldo}");
        }
    }
}
