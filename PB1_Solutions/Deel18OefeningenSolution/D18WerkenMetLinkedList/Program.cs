namespace D18WerkenMetLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> taken = new LinkedList<string>();
            taken.AddLast("Email beantwoorden");
            taken.AddLast("Rapport schrijven");
            taken.AddLast("Server herstarten");
            taken.AddFirst("Urgente bug fix");
            taken.AddAfter(taken.Find("Rapport schrijven"), "Documentatie bijwerken");
            taken.Remove("Email beantwoorden");

            int taaknummer = 1;
            foreach(string taak in taken)
            {
                Console.WriteLine($"Taak {taaknummer}: {taak}.");
                taaknummer++;
            }
        }
    }
}
