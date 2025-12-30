using D15Huisdieren.Domein;

namespace D15Huisdieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] huisdierInfo = File.ReadAllLines(@".\D15Huisdieren\Data\huisdieren.csv");
            List<Huisdier> huisdieren = new List<Huisdier>();
            try
            {
                foreach (string dier in huisdierInfo)
                {
                    string[] parameters = dier.Split(';');
                    huisdieren.Add(new Huisdier(parameters[0], parameters[1], int.Parse(parameters[2])));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach(Huisdier dier in huisdieren)
            {
                Console.WriteLine(dier.ToString());
            }
            
        }
    }
}
