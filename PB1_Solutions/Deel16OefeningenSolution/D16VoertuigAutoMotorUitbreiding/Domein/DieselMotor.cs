namespace D16VoertuigAutoMotorUitbreiding.Domein
{
    internal class DieselMotor : Motor
    {
        public override void StartMotor()
        {
            Console.WriteLine("De dieselmotor start.");
        }
    }
}
