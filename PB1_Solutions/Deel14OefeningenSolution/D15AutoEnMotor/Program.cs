namespace D15AutoEnMotor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(new Motor(150));
            Console.WriteLine(auto.Motor.IsGestart);
            auto.StartMotor();
            Console.WriteLine(auto.Motor.IsGestart);
        }
    }
}
