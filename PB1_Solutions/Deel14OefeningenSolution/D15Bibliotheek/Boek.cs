namespace D15Bibliotheek
{
    internal class Boek
    {
        private string _titel = "";
        public string Titel
        {
            get
            {
                return _titel;
            }
            set
            {
                if (value.Trim().Length == 0) throw new ArgumentException("De titel moet karakters bevatten die geen spaties zijn.");
                else _titel = value;
            }
        }
        
        public Boek(string titel)
        {
            Titel = titel;
        }
    }
}
