using static System.Net.Mime.MediaTypeNames;

namespace D18Opleidingen.Domein
{
    internal class Opleiding
    {
        public string Naam { get; set; }

        private int _studiepunten;

        public int Studiepunten
        {
            get
            {
                return _studiepunten;
            }
            set
            {
                if (value < 60 || value > 300) throw new ArgumentOutOfRangeException("Studiepunten moeten tussen 60 en 300 liggen.");
                _studiepunten = value;
            }
        }

        public HashSet<Student> Studenten { get; set; } = new HashSet<Student>();

        public Opleiding(string naam, int studiepunten)
        {
            Naam = naam;
            Studiepunten = studiepunten;
        }

        public string GeefStudentenlijst()
        {
            string tekst = "";
            foreach (Student student in Studenten)
                tekst += $"\n\t{student.ToString()}";
            return tekst;
        }

        public override string ToString()
        {
            string tekst = $"{Naam} ({Studiepunten} studiepunten) - {Studenten.Count} studenten" + GeefStudentenlijst();
            return tekst;
        }
    }
}
