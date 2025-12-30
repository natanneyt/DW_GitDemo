namespace D16Werknemers.Domein
{
    internal class Manager : Werknemer
    {
        public Manager(string naam) : base(naam) { }

        public override void Werk()
        {
            PlanVergadering();
        }

        public void PlanVergadering()
        {
            Console.WriteLine("Ik plan een vergadering.");
        }
    }
}
