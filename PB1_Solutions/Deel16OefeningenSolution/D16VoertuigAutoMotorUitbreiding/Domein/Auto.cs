namespace D16VoertuigAutoMotorUitbreiding.Domein
{
    internal class Auto : Voertuig
    {
        public Motor Motor { get; set; }

        public Auto(Motor motor)
        {
            Motor = motor;
        }

        public override void Start()
        {
            Console.WriteLine("De auto wordt gestart.");
            Motor.StartMotor();
        }
    }
}
