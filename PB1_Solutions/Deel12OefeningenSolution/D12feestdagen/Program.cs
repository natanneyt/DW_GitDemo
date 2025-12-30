namespace D12feestdagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jaar = DateTime.Now.Year;
            DateTime[] data = { 
                new DateTime(jaar,1,1),
                new DateTime(jaar, 4, 21),
                new DateTime(jaar,5,1),
                new DateTime(jaar,5,29),
                new DateTime(jaar,6,9),
                new DateTime(jaar,7,21),
                new DateTime(jaar,8,15),
                new DateTime(jaar,11,1),
                new DateTime(jaar,11,11),
                new DateTime(jaar,12,25)};
            string[] feestdag = { 
                "Nieuwjaar", 
                "Paasmaandag", 
                "Dag van de Arbeid", 
                "O. H. Hemelvaart", 
                "Pinkstermaandag", 
                "Nationale feestdag", 
                "O. L. V. Hemelvaart", 
                "Allerheiligen", 
                "Wapenstilstand", 
                "Kerstmis" };

            bool isFeestdag = false;

            try
            {
                Console.Write("Geef een datum: ");
                DateTime datum  = DateTime.Parse(Console.ReadLine());
                
                foreach(DateTime dt in data)
                {
                    if (dt.Date == datum.Date)
                    {
                        Console.WriteLine($"Dat is de \"{feestdag[Array.IndexOf(data, dt)]}\"!");
                        isFeestdag = true;
                    }
                }
                if (!isFeestdag) Console.WriteLine("Dit is geen feestdag.");
            }
            catch
            {
                Console.WriteLine("Dit is geen geldige datum.");
            }
        }
    }
}
