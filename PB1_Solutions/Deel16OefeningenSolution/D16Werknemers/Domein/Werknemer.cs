namespace D16Werknemers.Domein
{
    abstract class Werknemer
    {
        public string Naam { get; set; }

        public Werknemer(string naam)
        {
            Naam = naam;
        }

        public abstract void Werk();
    }
}
