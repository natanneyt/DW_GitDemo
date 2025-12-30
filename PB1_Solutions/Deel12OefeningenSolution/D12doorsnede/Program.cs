namespace D12doorsnede
{
    class Program
    {
        static void Main()
        {
            double[] temperaturenMeetpunt1 = { 10.1, 20.2, 15.5, 12.3, 28.7 };
            double[] temperaturenMeetpunt2 = { 10.0, 20.2, 15.6, 12.3, 28.8, 11.1 };

            double[] doorsnede = Doorsnede(temperaturenMeetpunt1, temperaturenMeetpunt2);
            ToonDoorsnede(doorsnede);                       // toont de tekst "20,2 | 12,3"

            double[] getallen1 = { 1.23, 2.34, 3.45 };
            double[] getallen2 = { 1.99, 2.34 };
            ToonDoorsnede(Doorsnede(getallen1, getallen2)); // toont de tekst "2,34"

            double[] getallen3 = { 1.99, 2.99, 3.99 };
            ToonDoorsnede(Doorsnede(getallen1, getallen3)); // toont de tekst "geen doorsnede"
        }

        static double[] Doorsnede(double[] getallen1, double[] getallen2)
        {
            double[] doorsnede = new double[getallen1.Length];
            int aantal = 0;
            foreach(double getal in getallen1)
            {
                for(int i = 0; i < getallen2.Length; i++)
                {
                    if (getal == getallen2[i])
                    {
                        doorsnede[aantal] = getal;
                        aantal++;
                    }
                }
            }
            return doorsnede;
        }

        static void ToonDoorsnede(double[] getallen)
        {
            // Dit negeert alle waarden die 0 zijn, ook als die in beide arrays zit.
            // Betere methode = twee keer controleren op de waardes in beide arrays in Doorsnede (de tweede keer nadat je de hoeveelheid in 'aantal' hebt berekend.

            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] != 0)
                {
                    if (i == getallen.Length - 1 || getallen[i + 1] == 0) Console.Write(getallen[i]);
                    else Console.Write($"{getallen[i]} | ");
                }
            }
            Console.WriteLine("");
        }
    }
}
