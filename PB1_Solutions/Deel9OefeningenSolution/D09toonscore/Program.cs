namespace D09toonscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vakken = { "Frans", "Engels", "Wiskunde", "Duits", "L.O." };
            int[] scores = { 34, 55, 20, 10, 80 };
            bool isVakGevonden = false;

            Console.Write("Vak: ");
            string inputVak = Console.ReadLine().ToLower().Trim();

            foreach(string vak in vakken)
            {
                if(vak.ToLower().Trim() == inputVak)
                {
                    Console.WriteLine($"De score voor dit vak is {scores[Array.IndexOf(vakken, vak)]}/100");
                    isVakGevonden = true;
                    break;
                }
            }
            if (!isVakGevonden) Console.WriteLine("Geen score gevonden.");
        }
    }
}
