namespace D11palindroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een woord: ");
            string invoer = Console.ReadLine().Trim();
            Console.WriteLine(IsPalindroom(invoer));
        }

        static bool IsPalindroom(string invoer)
        {
            if (invoer.Length == 0) return false;
            bool resultaat = true;
            for (int i = 0; i < invoer.Length / 2; i++)
            {
                if (invoer[i] != invoer[invoer.Length - i - 1])
                    resultaat = false;
            }
            return resultaat;
        }
    }
}
