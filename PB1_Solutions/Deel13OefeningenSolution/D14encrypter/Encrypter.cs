namespace D14encrypter
{
    internal class Encrypter
    {
        private string _codewiel = "0ab1cd2ef3gh4ij5kl6m n7op8qr9st.uv,wx!yz?";

        public int Verschuiving { get; set; }

        public Encrypter(int verschuiving)
        {
            Verschuiving = verschuiving;
        }

        public string Encrypt(string tekst)
        {
            string resultaat = "";
            bool isGevonden = false;
            foreach (char karakter in tekst)
            {
                isGevonden = false;

                int index = 0;
                foreach (char codeKarakter in _codewiel)
                {
                    if (karakter == codeKarakter)
                    {
                        try
                        {
                            if (_codewiel.Length - 1 < index + Verschuiving)
                            {
                                int rest = (index + Verschuiving) - (_codewiel.Length - 1);
                                resultaat += _codewiel[rest - 1];
                            }

                            else if (0 > index + Verschuiving)
                            {
                                int rest = Math.Abs(0 + (index + Verschuiving));
                                resultaat += _codewiel[_codewiel.Length - rest];
                            }
                            else resultaat += _codewiel[index + Verschuiving];
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
