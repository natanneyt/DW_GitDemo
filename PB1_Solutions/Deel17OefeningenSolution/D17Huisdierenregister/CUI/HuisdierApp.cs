using D17Huisdierenregister.Domein;

namespace D17Huisdierenregister.CUI
{
    internal class HuisdierApp
    {
        static void Main(string[] args)
        {
            HuisdierManager manager = new HuisdierManager();
            manager.LeesHuisdieren(@".\D17Huisdierenregister\Data\huisdieren.txt");

            List<Huisdier> huisdieren = manager.GeefHuisdieren();

            if(huisdieren.Count() > 0)
            {
                foreach (Huisdier huisdier in huisdieren)
                    Console.WriteLine(huisdier);
            }

            string foutenlijst = @".\D17Huisdierenregister\Data\foutenlijst.txt";
            if (File.Exists(foutenlijst)) Console.WriteLine($"\nEr zijn fouten opgetreden: zie {foutenlijst}");
        }
    }
}
