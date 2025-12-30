using D15RegisterVanVoertuigen.Domein;
using System.Text.RegularExpressions;

namespace D15RegisterVanVoertuigen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] voertuigenInfo = File.ReadAllLines(@".\D15RegisterVanVoertuigen\Data\voertuigen.csv");
            List<Voertuig> voertuigen = new List<Voertuig>();

            bool isKlaar = false;
            int counter = 0;

            while (!isKlaar)
            {
                counter = 0;
                foreach (string regel in voertuigenInfo)
                {
                    string[] parameters = regel.Split(';');
                    try
                    {
                        if (parameters.Length == 3)
                        {
                            voertuigen.Add(new Voertuig(parameters[0], int.Parse(parameters[1]), int.Parse(parameters[2])));
                            voertuigenInfo[counter] = ";";
                        }
                        counter++;
                        if (counter == voertuigenInfo.Length - 1) isKlaar = true;
                    }
                    catch
                    {
                        Console.WriteLine("Er liep iets mis.");
                    }
                }
            }



            foreach (Voertuig voertuig in voertuigen)
                Console.WriteLine(voertuig.ToString());
        }
    }
}
