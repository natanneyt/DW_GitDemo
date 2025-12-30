using D17Bibliotheekcatalogus.Persistentie;

namespace D17Bibliotheekcatalogus.Domein
{
    internal class PublicatieManager
    {
        List<Publicatie> _publicaties = new List<Publicatie>();

        public void LeesPublicaties(string relatiefPad)
        {
            PublicatieBestandIO publicatieIO = new PublicatieBestandIO();

            _publicaties = publicatieIO.LeesPublicaties(relatiefPad);
        }

        public List<Publicatie> GeefPublicaties()
        {
            return _publicaties;
        }
    }
}
