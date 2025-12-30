using D17Huisdierenregister.Persistentie;

namespace D17Huisdierenregister.Domein
{
    internal class HuisdierManager
    {
        private List<Huisdier> _huisdieren = new List<Huisdier>();

        public void LeesHuisdieren(string relatiefPad)
        {
            HuisdierBestandIO bestandIO = new HuisdierBestandIO();
            _huisdieren =  bestandIO.LeesHuisdieren(relatiefPad);
        }

        public List<Huisdier> GeefHuisdieren()
        {
            return _huisdieren;
        }
    }
}
