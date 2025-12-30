using D18Opleidingen.Persistentie;

namespace D18Opleidingen.Domein
{
    internal class StudentManager
    {
        public List<Opleiding> Opleidingen { get; set; }

        public void LeesOpleidingen(string relatiefPad)
        {
            Opleidingen = StudentenBestandIO.LeesOpleidingen(relatiefPad);
        }

        public List<Opleiding> GeefOpleidingen()
        {
            return Opleidingen;
        }
    }
}
