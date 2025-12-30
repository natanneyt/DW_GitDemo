namespace D15AutoEnMotor
{
    internal class Motor
    {
        public bool IsGestart { get; set; }

        public double Vermogen { get; set; }

        public Motor(double vermogen)
        {
            IsGestart = false;
            Vermogen = vermogen;
        }
    }
}
