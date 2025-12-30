namespace D16Werknemers.Domein
{
    internal class Programmeur : Werknemer
    {
        public Programmeur(string naam) : base(naam) { }

        public override void Werk()
        {
            SchrijfCode();
        }

        public void SchrijfCode()
        {
            Console.WriteLine("Ik schrijf code.");
        }
    }
}
