namespace FactoryMethodPattern.Models
{
    internal class ShipFactory : TransportationFactory
    {
        public override Transportation Construct()
        {
            return new Ship();
        }
    }
}