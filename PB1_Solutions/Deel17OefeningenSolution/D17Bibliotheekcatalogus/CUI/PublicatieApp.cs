using D17Bibliotheekcatalogus.Domein;

namespace D17Bibliotheekcatalogus.CUI
{
    internal class PublicatieApp
    {
        static void Main(string[] args)
        {
            PublicatieManager manager = new PublicatieManager();
            manager.LeesPublicaties(@".\D17Bibliotheekcatalogus\Data\publicaties.txt");

            List<Publicatie> publicaties = manager.GeefPublicaties();
            if(publicaties.Count > 0)
            {
                foreach(Publicatie publicatie in publicaties)
                {
                    Console.WriteLine(publicatie);
                }
            }

            string foutenlijstPad = @".\D17Bibliotheekcatalogus\Data\foutenlijst.txt";
            if (File.Exists(foutenlijstPad))
                Console.WriteLine($"Er zijn fouten opgetreden: zie {foutenlijstPad}");
        }
    }
}
