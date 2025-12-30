namespace D14expressies4
{
    class Program
    {
        static void Main()
        {
            // g is een int
            // g > 5 is een bool-expressie en is toegelaten
            // 6 is geen bool-expressie en geeft dus geen true/false weer, dit is niet toegelaten
            int g = 4;
            while (g > 5 && 6)
            {
                /* ... */
            }
        }
    }
}
