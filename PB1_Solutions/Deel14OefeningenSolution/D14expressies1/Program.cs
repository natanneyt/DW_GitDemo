namespace D14expressies1
{
    class Factuur
    {
        public int Id { get; set; }
        public DateTime CreatieDatum { get; set; }
    }

    class Program
    {
        static void Main()
        {
            DateTime d = new DateTime(2017, 3, 12);

            // GetFactuur() geeft een Factuur terug
            // 5 heeft als type int
            // d heeft als type DateTime
            // CreatieDatum heeft als type DateTime
            // Day heeft als type int
            // WriteLine() heeft een overload waarmee je een int (de eindwaarde) kan printen = dit is toegelaten
            Console.WriteLine(GetFactuur(5, d).CreatieDatum.Day);
        }
        static Factuur GetFactuur(int id, DateTime creatieDatum)
        {
            Factuur f = new Factuur();
            f.Id = id;
            f.CreatieDatum = creatieDatum;
            return f;
        }
    }
}
