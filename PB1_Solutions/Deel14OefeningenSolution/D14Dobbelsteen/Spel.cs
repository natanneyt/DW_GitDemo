namespace D14Dobbelsteen
{
    internal class Spel
    {
        public int Score { get; set; }

        public int EersteWorp { get; set; } = -1;

        public List<Dobbelsteen> Dobbelstenen { get; set; } = new List<Dobbelsteen>();

        private bool _isSpelGedaan = false;

        public Spel(int aantalDobbelstenen)
        {
            for (int i = 0; i < aantalDobbelstenen; i++)
                Dobbelstenen.Add(new Dobbelsteen());
        }

        public void StartNieuwSpel()
        {
            _isSpelGedaan = false;
            RolDobbelstenen();
        }

        private void RolDobbelstenen()
        {
            while (!_isSpelGedaan)
            {
                int totaalAantalOgen = 0;
                foreach (Dobbelsteen dobbelsteen in Dobbelstenen)
                {
                    dobbelsteen.RolDobbelsteen();
                    totaalAantalOgen+= dobbelsteen.AantalOgen;
                }
                ToonAantalOgenWorp(totaalAantalOgen);
                BerekenScore(totaalAantalOgen);
            }
        }

        private void ToonAantalOgenWorp(int totaalAantalOgen)
        {
            Console.WriteLine($"Aantal ogen van de laatste worp: {totaalAantalOgen}");
        }

        private void BerekenScore(int totaalAantalOgen)
        {
            if(EersteWorp == -1)
            {
                if (totaalAantalOgen == 7 || totaalAantalOgen == 11)
                {
                    Score = 2;
                    _isSpelGedaan = true;
                    ToonEindscore();
                }
                EersteWorp = totaalAantalOgen;
            }
            else if(totaalAantalOgen == EersteWorp)
            {
                Score = 1;
                _isSpelGedaan = true;
                ToonEindscore();
            }
            else if(totaalAantalOgen == 7 || totaalAantalOgen == 11)
            {
                Score = 0;
                _isSpelGedaan = true;
                ToonEindscore();
            }
        }

        private void ToonEindscore()
        {
            Console.WriteLine($"Eindscore: {Score}.");
        }
    }
}