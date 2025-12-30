namespace D15RestaurantEnMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            restaurant.VoegMenuItemToe(new MenuItem("Naam1", 10.99));
            restaurant.VoegMenuItemToe(new MenuItem("Naam2", 12.89));
            restaurant.VoegMenuItemToe(new MenuItem("Naam3", 19.99));
            restaurant.VoegMenuItemToe(new MenuItem("Naam4", 7.24));
            restaurant.VoegMenuItemToe(new MenuItem("Naam5", 2.99));
            restaurant.VoegMenuItemToe(new MenuItem("Naam6", 9.49));

            restaurant.DrukMenuAf();
        }
    }
}
