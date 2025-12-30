namespace D15Spaarpot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spaarpot spaarpot = new Spaarpot();

            try
            {
                Muntstuk muntstuk = new Muntstuk(-5);
                spaarpot.VoegMuntstukToe(muntstuk);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Muntstuk muntstuk1 = new Muntstuk(5);
            Muntstuk muntstuk2 = new Muntstuk(10);
            Muntstuk muntstuk3 = new Muntstuk(25);
            Muntstuk muntstuk4 = new Muntstuk(50);
            Muntstuk muntstuk5 = new Muntstuk(100);
            Muntstuk muntstuk6 = new Muntstuk(200);

            spaarpot.VoegMuntstukToe(muntstuk1);
            spaarpot.VoegMuntstukToe(muntstuk1);
            spaarpot.VoegMuntstukToe(muntstuk2);
            spaarpot.VoegMuntstukToe(muntstuk3);
            spaarpot.VoegMuntstukToe(muntstuk4);
            spaarpot.VoegMuntstukToe(muntstuk5);
            spaarpot.VoegMuntstukToe(muntstuk6);


            Console.WriteLine($"Er zit {spaarpot.GeefTotaalbedrag()} euro in de spaarpot.");
        }
    }
}
