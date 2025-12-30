using D16Werknemers.Domein;

namespace D16Werknemers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Werknemer[] werknemers = new Werknemer[2];
            werknemers[0] = new Programmeur("naam1");
            werknemers[1] = new Manager("naam2");

            foreach(Werknemer werknemer in werknemers)
            {
                werknemer.Werk();
            }
        }
    }
}
