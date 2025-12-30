namespace D15Opleidingen.Domein
{
    internal class Student
    {
        public string Naam { get; set; }

        public int Leeftijd { get; set; }

        public Opleiding Opleiding { get; set; }

        public Student(string naam, int leeftijd, Opleiding opleiding)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Opleiding = opleiding;
        }

        public override string ToString()
        {
            return $"{Naam} ({Leeftijd}) is ingeschreven in {Opleiding.ToString()}";
        }
    }
}
