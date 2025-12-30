namespace D15LaptopEnBatterij
{
    internal class Batterij
    {
        private int _laadniveau;

        public int Laadniveau 
        { 
            get 
            { 
                return _laadniveau;
            }
            set 
            { 
                _laadniveau = Math.Clamp(value, 0, 100); 
            }
        }

        public Batterij(int laadniveau)
        {
            Laadniveau = laadniveau;
        }
    }
}
