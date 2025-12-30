namespace D15RestaurantEnMenu
{
    internal class Restaurant
    {
        List<MenuItem> Menu { get; private set; } = new List<MenuItem>();

        public Restaurant() { }

        public void VoegMenuItemToe(MenuItem item) 
        {
            Menu.Add(item);
        }

        public void DrukMenuAf()
        {
            Console.WriteLine("------- Menu -------");
            foreach(MenuItem item in Menu)
            {
                Console.WriteLine($"{item.Naam}{item.Prijs.ToString(),15}");
            }
        }
    }
}
