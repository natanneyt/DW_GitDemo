namespace D12seizoen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Geef een datum: ");
                    string invoer = Console.ReadLine();
                    DateTime datum = DateTime.Parse(invoer);

                    string seizoen = "";
                    if ((datum >= DateTime.Parse("01/01") && datum < DateTime.Parse("01/03")) || (datum >= DateTime.Parse("01/12") && datum <= DateTime.Parse("31/12")))
                    {
                        seizoen = "Winter";
                    }
                    else if (datum >= DateTime.Parse("01/03") && datum < DateTime.Parse("01/06"))
                    {
                        seizoen = "Lente";
                    }
                    else if (datum >= DateTime.Parse("01/06") && datum < DateTime.Parse("01/09"))
                    {
                        seizoen = "Zomer";
                    }
                    else seizoen = "Herfst";

                    Console.WriteLine(seizoen);
                    break;
                }
                catch
                {
                    Console.WriteLine("Ongeldige datum.");
                }
            }
            while (true);
        }
    }
}
