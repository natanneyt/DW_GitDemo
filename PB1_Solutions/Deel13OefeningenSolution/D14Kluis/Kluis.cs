namespace D14Kluis
{
    internal class Kluis
    {
        public bool IsOpen { get; private set; }

        private int _pincode;

        public Kluis(int pincode)
        {
            IsOpen = false;
            _pincode = pincode;
        }

        public void OpenKluis(int pincode)
        {
            if (_pincode == pincode) IsOpen = true;
        }

        public void SluitKluis()
        {
            IsOpen = false;
        }
    }
}
