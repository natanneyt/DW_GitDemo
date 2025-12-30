namespace D18WerkenMetHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> emailadressen = new List<string> { "email1", "email1", "email3", "info@bedrijf.com", "email3", "email6" };
            HashSet<string> emailadressenHashed = new HashSet<string>(emailadressen);
            string emailTeControleren = "info@bedrijf.com";
            if (emailadressenHashed.Contains(emailTeControleren)) Console.WriteLine($"{emailTeControleren} is aanwezig.\n");

            foreach(string email in emailadressenHashed)
            {
                Console.WriteLine(email);
            }
        }
    }
}
