namespace D12palindroom
{
    internal class Program
    {
        // D12documentatie
        // Sleep(): https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep?view=net-9.0
        // ReadKey(): https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-9.0

        // D12palindroom call stack (regel 19)
        // ReverseText(string [invoer]) gebroken op regel 19 | result = ||
        // IsPalindroom(string [invoer])
        // Main() | tekst = [invoer]

        static void Main()
        {
            Console.WriteLine("Geef een tekst : ");
            string tekst = Console.ReadLine();

            Console.WriteLine(IsPalindroom(tekst));
        }

        static bool IsPalindroom(string tekst)
        {
            string reverse = ReverseText(tekst);
            if (tekst == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ReverseText(string tekst)
        {
            string result = "";
            foreach (char c in tekst)
            {
                result += c.ToString();
            }
            return result;
        }
    }
}
