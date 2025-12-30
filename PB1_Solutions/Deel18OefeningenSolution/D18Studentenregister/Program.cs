using System.Text.Json.Serialization.Metadata;

namespace D18Studentenregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namen = new List<string> { "naam1", "naam2", "naam1", "naam4", "naam3" };
            List<string> emailadressen = new List<string> { "email1", "email2", "email1", "email4", "email3" };
            HashSet<string> emailadressenHashed = new HashSet<string>(emailadressen);
            Dictionary<string, string> studenten = new Dictionary<string, string>();

            for (int i = 0; i < namen.Count; i++)
            {
                if(emailadressenHashed.Contains(emailadressen[i])) studenten[namen[i]] = emailadressen[i];
            }

            foreach (string emailadres in studenten.Keys)
            {
                studenten.TryGetValue(emailadres, out string naam);
                Console.WriteLine($"{naam}: {emailadres}");
            }

            Console.WriteLine("Geef een emailadres in.");
            string input = Console.ReadLine();
            bool komtVoor = false;
            foreach(string naam in studenten.Keys)
            {
                studenten.TryGetValue(naam, out string email);
                if (email == input)
                {
                    Console.WriteLine(naam);
                    komtVoor = true;
                }
            }
            if (!komtVoor) Console.WriteLine("Deze waarde komt niet voor in de lijst.");


        }
    }
}
