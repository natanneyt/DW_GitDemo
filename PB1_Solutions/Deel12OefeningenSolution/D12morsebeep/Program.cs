namespace D12morsebeep
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int frequentie = 750;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.Key >= ConsoleKey.A && cki.Key <= ConsoleKey.Z)
                    {
                        PlayBeep(Morse(cki.Key.ToString().ToLower().ToCharArray()[0]), frequentie);
                    }
                }
            }

            static void PlayBeep(string morse, int frequentie)
            {
                foreach (char c in morse)
                {
                    if (c == '.')
                    {
                        Console.WriteLine("kort");
                        Console.Beep(frequentie, 750);
                        System.Threading.Thread.Sleep(250);
                    }
                    else if (c == '-')
                    {
                        Console.WriteLine("lang");
                        Console.Beep(frequentie, 1000);
                        System.Threading.Thread.Sleep(250);
                    }
                }
            }

            static string Morse(char c)
            {
                char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

                return morse[Array.IndexOf(letters, c)];
            }
        }
    }
}
