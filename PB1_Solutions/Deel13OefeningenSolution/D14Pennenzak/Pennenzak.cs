namespace D14Pennenzak
{
    internal class Pennenzak
    {
        public string Kleur { private get; set; }

        public double Lengte { get; set; }

        public bool IsOpen { get; set; }

        public Pennenzak(string kleur, double lengte, bool isOpen)
        {
            Kleur = kleur;
            Lengte = lengte;
            IsOpen = isOpen;
        }

        public void OpenPennenzak()
        {
            IsOpen = true;
        }

        public void SluitPennenzak()
        {
            IsOpen = false;
        }

        public string VraagKleur()
        {
            return Kleur;
        }
    }
}
