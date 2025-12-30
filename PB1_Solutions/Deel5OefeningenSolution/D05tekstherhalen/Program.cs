namespace D05tekstherhalen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Geef een stuk tekst: ");
                string tekst = Console.ReadLine();

                Console.Write("Geef een getal: ");
                int aantal = int.Parse(Console.ReadLine());

                int huidigeIteratie = 1;
                //do
                //{
                //    Console.Write(tekst);
                //    if (huidigeIteratie + 1 == aantal) Console.Write(tekst.ToUpper());
                //    huidigeIteratie++;

                //} while (huidigeIteratie + 1 <= aantal);

                while (huidigeIteratie < aantal)
                {
                    huidigeIteratie++;
                    Console.Write(tekst);
                    if (huidigeIteratie == aantal) Console.Write(tekst.ToUpper());
                }
            }
            catch
            {

            }
        }
    }
}
