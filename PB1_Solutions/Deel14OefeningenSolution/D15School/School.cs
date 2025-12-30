namespace D15School
{
    internal class School
    {
        public List<Klas> Klassen { get; private set; } = new List<Klas>();

        public School() { }

        public void DrukNamenAf()
        {
            foreach(Klas klas in Klassen)
            {
                foreach(Student student in klas.Studenten)
                {
                    Console.WriteLine(student.Naam);
                }
            }
        }

        public void VoegKlasToe(Klas klas)
        {
            Klassen.Add(klas);
        }
    }
}
