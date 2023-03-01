using FactoryMethodPattern.Models;

namespace FactoryMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Transportation airplane = new AirplaneFactory().Construct();
            airplane.Deliver();

            Transportation car = new CarFactory().Construct();
            car.Deliver();

            Transportation ship = new ShipFactory().Construct();
            ship.Deliver();
        }
    }
}

