namespace D14encrypter
{
    internal class Program
    {
        static void Main()
        {
            Encrypter e5 = new Encrypter(5);
            Encrypter e10 = new Encrypter(10);
            Encrypter e1 = new Encrypter(1);
            Encrypter e40 = new Encrypter(40);
            Encrypter e41 = new Encrypter(41);
            Encrypter em1 = new Encrypter(-1);
            Encrypter em10 = new Encrypter(-10);
            Encrypter em40 = new Encrypter(-40);
            Encrypter em41 = new Encrypter(-41);
            Encrypter em82 = new Encrypter(-82);

            const string codewiel = "0ab1cd2ef3gh4ij5kl6m n7op8qr9st.uv,wx!yz?";


            string tekst = "a19z";
            string code = e5.Encrypt(tekst);

            Console.WriteLine("+ 5 " + tekst + "->" + code);
            // de output is  : + 5 a19z->2fv1

            tekst = "GROEN";
            Console.WriteLine("+ 5 " + tekst + "->" + e5.Encrypt(tekst));
            // de output is  : + 5 GROEN->GROEN

            tekst = "c# !";
            Console.WriteLine("+10 " + tekst + "->" + e10.Encrypt(tekst));
            // de output is  : +10 c# !->j#t2

            Console.WriteLine();

            tekst = "0allo?";
            Console.WriteLine("+ 1 " + tekst + "->" + e1.Encrypt(tekst));
            // de output is  : + 1 0allo?->ab66p0

            Console.WriteLine("+40 " + tekst + "->" + e40.Encrypt(tekst));
            // de output is  : +40 0allo?->?0kk7z

            Console.WriteLine("+41 " + tekst + "->" + e41.Encrypt(tekst));
            // de output is  : +41 0allo?->0allo?

            Console.WriteLine("- 1 " + tekst + "->" + em1.Encrypt(tekst));
            // de output is  : - 1 0allo?->?0kk7z

            Console.WriteLine();

            Console.WriteLine("-10 " + tekst + "->" + em10.Encrypt(tekst));
            // de output is  : -10 0allo?->.ueeit

            Console.WriteLine("-40 " + tekst + "->" + em40.Encrypt(tekst));
            // de output is  : -40 0allo?->ab66p0

            Console.WriteLine("-41 " + tekst + "->" + em41.Encrypt(tekst));
            // de output is  : -41 0allo?->0allo?

            Console.WriteLine("-82 " + tekst + "->" + em82.Encrypt(tekst));
            // de output is  : -82 0allo?->0allo?
        }

        static string GetEncryptedCodeFor(string tekst, string codewiel, int offset)
        {
            string resultaat = "";
            bool isGevonden = false;
            foreach (char karakter in tekst)
            {
                isGevonden = false;

                int index = 0;
                foreach (char codeKarakter in codewiel)
                {
                    if (karakter == codeKarakter)
                    {
                        try
                        {
                            if (codewiel.Length - 1 < index + offset)
                            {
                                int rest = (index + offset) - (codewiel.Length - 1);
                                resultaat += codewiel[rest - 1];
                            }

                            else if (0 > index + offset)
                            {
                                int rest = Math.Abs(0 + (index + offset));
                                resultaat += codewiel[codewiel.Length - rest];
                            }
                            else resultaat += codewiel[index + offset];
                            isGevonden = true;
                        }
                        catch { }
                    }
                    index++;
                }
                if (!isGevonden) resultaat += karakter;
            }
            return resultaat;
        }
    }
}
