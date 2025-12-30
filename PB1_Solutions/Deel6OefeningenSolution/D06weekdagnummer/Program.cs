namespace D06weekdagnummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Geef een dagnummer: ");

                int dagNummer = int.Parse(Console.ReadLine());

                string dag = dagNummer switch
                {
                    1 => "maandag",
                    2 => "dinsdag",
                    3 => "woensdag",
                    4 => "donderdag",
                    5 => "vrijdag",
                    6 => "zaterdag",
                    7 => "zondag",
                    _ => ""
                };
                Console.WriteLine($"Dagnummer {dagNummer} is {dag}.");
            }
            catch { }


        }
    }
}
