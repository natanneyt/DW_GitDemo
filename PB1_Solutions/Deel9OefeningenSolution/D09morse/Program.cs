namespace D09morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            string eindTekst = "";
            try
            {
                do
                {
                    Console.Write("Morse voor de volgende letter (. voor kort, - voor lang): ");
                    string morseCode = Console.ReadLine();
                    if (morse.Contains(morseCode))
                    {
                        eindTekst += letters[Array.IndexOf(morse, morseCode)];
                        Console.WriteLine(eindTekst);
                    }
                    else Console.WriteLine("Ongeldige morsecode.");

                } while (true);
            }
            catch { }
        }
    }
}
