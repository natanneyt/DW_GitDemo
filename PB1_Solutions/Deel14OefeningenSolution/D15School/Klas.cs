namespace D15School
{
    internal class Klas
    {
        public List<Student> Studenten { get; private set; } = new List<Student>();

        public string Naam { get; set; }

        public Klas(string naam) 
        { 
            Naam = naam;
        }

        public void VoegStudentToe(Student student)
        {
            Studenten.Add(student);
        }
    }
}
