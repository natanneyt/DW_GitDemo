namespace D15School
{
    internal class Student
    {
        private string _naam;

        public string Naam
        {
            get
            {
                return _naam;
            }
            set
            {
                if (value.Trim().Length == 0) throw new ArgumentException("De naam moet karakters bevatten die geen spaties zijn.");
                else _naam = value;
            }
        }

        public Student(string naam)
        {
            Naam = naam;
        }
    }
}
