namespace D11reversearray
{
    internal class Program
    {
        static void Main()
        {
            string[] test0 = { }; // Duizend bommen en granaten Kuifje, een leeg array!
            string[] test1 = { "een" };
            string[] test2 = { "een", "twee" };
            string[] test3 = { "een", "twee", "drie" };
            string[] test4 = { "een", "twee", "drie", "vier" };
            string[] test5 = { "een", "twee", "drie", "vier", "vijf" };

            string[] woorden = test5;

            Console.WriteLine(string.Join(", ", woorden));
            Reverse(woorden);
            Console.WriteLine(string.Join(", ", woorden));
        }

        static void Reverse(string[] woorden)
        {
            string[] tempWoorden = new string[woorden.Length];

            for (int i = 0; i < tempWoorden.Length; i++)
            {
                tempWoorden[i] = woorden[woorden.Length - 1 - i];
            }

            for (int i = 0; i < tempWoorden.Length; i++)
            {
                woorden[i] = tempWoorden[i];
            }
        }
    }
}
