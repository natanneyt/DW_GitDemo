namespace D14Lamp
{
    internal class Lamp
    {
        public string Kleur { get; private set; }

        public bool IsAan { get; private set; }

        public Lamp(string kleur, bool isAan)
        {
            Kleur = kleur;
            IsAan = isAan;
        }

        public void ZetAan()
        {
            IsAan = true;
        }

        public void ZetUit()
        {
            IsAan = false;
        }
    }
}
