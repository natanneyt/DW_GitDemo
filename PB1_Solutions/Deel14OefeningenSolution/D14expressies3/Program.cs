namespace D14expressies3
{
    class Program
    {
        static void Main()
        {
            // a is een string array
            // new int [] { 1, 2, 3 } is een int array
            // .Length geeft als waarde een int terug
            // .Length * 5 = int-waarde
            // new string[int-waarde] is toegestaan

            string[] a = new string[new int[] { 1, 2, 3 }.Length * 5];
        }
    }
}
