namespace D18Opleidingen.Domein
{
    internal class Student : IComparable<Student>
    {
        public string StudentNummer { get; set; }

        public string Naam { get; set; }

        public int Leeftijd { get; set; }

        public Student(string studentnummer, string naam, int leeftijd)
        {
            StudentNummer = studentnummer;
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public override string ToString()
        {
            return $"{StudentNummer} - {Naam} ({Leeftijd} jaar)";
        }

        public int CompareTo(Student? other)
        {
            if (other != null && other.GetType().Name == GetType().Name)
            {
                Student student = other as Student;
                return StudentNummer.CompareTo(student.StudentNummer);
            }
            else throw new Exception("Fout object ingegeven.");
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj.GetType().Name == GetType().Name)
            {
                Student student = obj as Student;
                return StudentNummer.Equals(student.StudentNummer);
            }
            else throw new Exception("Fout object ingegeven.");
        }

        public override int GetHashCode()
        {
            return StudentNummer.GetHashCode();
        }
    }
}
