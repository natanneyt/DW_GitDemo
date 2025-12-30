namespace D16VoertuigAutoMotor.Domein
{
    abstract class Voertuig
    {
        public string Merk { get; set; }

        public abstract void Start();
    }
}
