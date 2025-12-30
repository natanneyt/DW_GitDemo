namespace D15AutoEnMotor
{
    internal class Auto
    {
        public Motor Motor { get; set; }

        public Auto(Motor motor)
        {
            Motor = motor;
        }

        public void StartMotor()
        {
            Motor.IsGestart = true;
        }
    }
}
