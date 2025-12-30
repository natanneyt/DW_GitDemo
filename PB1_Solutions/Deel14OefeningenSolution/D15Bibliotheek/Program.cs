namespace D15Bibliotheek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Boek boek1 = new Boek("BOEK1");
                Boek boek2 = new Boek("BOEK2");
                Boek boek3 = new Boek("BOEK3");
                Boek boek4 = new Boek("BOEK4");
                Boek boek5 = new Boek("BOEK5");
                Boek boek6 = new Boek("BOEK6");

                Bibliotheek bibliotheek = new Bibliotheek();

                bibliotheek.VoegBoekToe(boek1);
                bibliotheek.VoegBoekToe(boek2);
                bibliotheek.VoegBoekToe(boek3);
                bibliotheek.VoegBoekToe(boek4);
                bibliotheek.VoegBoekToe(boek5);
                bibliotheek.VoegBoekToe(boek6);
                Console.WriteLine(bibliotheek.GeefAantalBoeken());

                Boek boek7 = new Boek("  ");
                bibliotheek.VoegBoekToe(boek7);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
