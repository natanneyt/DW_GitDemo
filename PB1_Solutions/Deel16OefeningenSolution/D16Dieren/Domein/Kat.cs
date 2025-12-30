namespace D16Dieren.Domein
{
    internal class Kat : Dier
    {
        public Kat(string naam) : base(naam) { }

        public override void GeefInfo()
        {
            base.GeefInfo();
            Console.Write(", kan spinnen.\n");
        }
    }
}
