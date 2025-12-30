namespace D14Jackpot
{
    internal class Jackpot
    {
        private List<Wiel> _wielen = new List<Wiel>();

        private const int AANTALWIELEN = 3;
        public Jackpot()
        {
            for(int i = 0; i < AANTALWIELEN; i++)
            {
                _wielen.Add(new Wiel());
            }
        }

        public List<int> GeefGetallenVanWielen()
        {
            List<int> getallen = new List<int>();
            foreach (Wiel wiel in _wielen)
                getallen.Add(wiel.Getal);
            return getallen;
        }

        public void Speel()
        {
            foreach(Wiel wiel in _wielen)
            {
                wiel.Draai();
            }
        }

        public int GeefScore()
        {
            List<int> getallen = GeefGetallenVanWielen();

            int getal1 = getallen[0];
            int aantalGelijkeGetallen = 0;
            foreach(int getal in getallen)
            {
                if (getal1 == getal) aantalGelijkeGetallen++;
            }
            if (getal1 == 9 && aantalGelijkeGetallen == 3) return 50;
            else if (aantalGelijkeGetallen == 3) return 10;
            else if (aantalGelijkeGetallen == 2) return 5;
            else return 0;

            // Indien je 3 maal een 9 hebt krijg je 50 punten
            // 3 dezelfde getallen is 10 punten
            // 2 dezelfde getallen is 5 punten
            // In alle andere gevallen krijg je 0 punten
        }
    }
}
