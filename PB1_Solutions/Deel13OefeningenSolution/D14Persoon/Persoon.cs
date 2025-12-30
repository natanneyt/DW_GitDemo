public class Persoon
{
    private string _naam;
    private DateTime _geboortedatum;
    private int _leeftijd;
    private string _woonplaats;

    private string[] _namen = new string[3] { "Jan", "Eric", "Wim" };

    public string Naam { get { return _naam; }
        set
        {
            if (value.Trim().Length < 1 || !_namen.Contains(value.Trim())) throw new ArgumentOutOfRangeException("Naam moet bestaan en mag niet enkel witruimte bevatten.");
            else _naam = value;
        }
    }

    public DateTime Geboortedatum { get { return _geboortedatum; }
        set
        {
            if (DateTime.Now.Ticks - value.Ticks < 0) throw new ArgumentOutOfRangeException("Geboortedatum moet in het verleden liggen.");
            else _geboortedatum = value;
        }
    }

    public int Leeftijd
    {
        get
        {
            int leeftijd = 0;
            DateTime dt = Geboortedatum.Date.AddYears(1);

            while (dt <= DateTime.Today)
            {
                leeftijd++;
                dt = dt.AddYears(1);
            }
            return leeftijd;
       }
   }
    
    public string Woonplaats { get { return _woonplaats; } set { _woonplaats = value; } }

    public Persoon(string naam, DateTime geboortedatum, string woonplaats)
    {
        Naam = naam;
        Geboortedatum = geboortedatum;
        _woonplaats = woonplaats;
    }

    public Persoon(string naam, string woonplaats) : this(naam, new DateTime(), woonplaats)
    {

    }

}