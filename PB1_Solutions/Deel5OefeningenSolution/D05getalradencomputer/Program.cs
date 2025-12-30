namespace D05getalradencomputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gok = 0;
            int beginGetal = 1;
            int eindGetal = 101;
            int aantalGokken = 0;
            bool isJuist = false;
            bool wordtHerhaald = false;

            Random random = new Random();
            do
            {
                if(!wordtHerhaald) gok = random.Next(beginGetal, eindGetal);
                Console.WriteLine($"De computer gokt {gok}, is jouw getal hoger/lager of was het juist?");
                string antwoord = Console.ReadLine();

                switch (antwoord)
                {
                    case "hoger":
                        {
                            beginGetal = gok + 1;
                            wordtHerhaald = false;
                            break;
                        }
                    case "lager":
                        {
                            eindGetal = gok;
                            wordtHerhaald = false;
                            break;
                        }
                    case "juist":
                        {
                            Console.Write("Het programma raadde je getal ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("in ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"{aantalGokken} gokken.");
                            isJuist = true;
                            break;
                        }
                    default:
                        {
                            wordtHerhaald = true;
                            break;
                        }
                }
                if(!wordtHerhaald) aantalGokken++;
            } while (!isJuist);
        }
    }
}
