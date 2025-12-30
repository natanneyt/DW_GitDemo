namespace D05somofverschil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultaat = 0;
            bool isPlus = true;
            try
            {
                do
                {
                    string invoer = Console.ReadLine();

                    switch (invoer)
                    {
                        case "=":
                            {
                                Console.WriteLine(resultaat);

                                break;
                            }
                        case "+":
                            {
                                isPlus = true;
                                break;
                            }
                        case "-":
                            {
                                isPlus = false;
                                break;
                            }
                        default:
                            {
                                int getal = int.Parse(invoer);
                                if (isPlus) resultaat += getal;
                                else resultaat -= getal;
                                break;
                            }
                    }
                } while (true);
            }
            catch
            {
                Console.WriteLine("Er liep iets mis.");
            }
        }
    }
}
