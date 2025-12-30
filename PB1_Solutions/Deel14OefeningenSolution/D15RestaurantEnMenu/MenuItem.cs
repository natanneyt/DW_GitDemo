namespace D15RestaurantEnMenu
{
    internal class MenuItem
    {
        public string Naam { get; set; }

        public double Prijs { get; set; }

        public MenuItem(string naam, double prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }
    }
}
