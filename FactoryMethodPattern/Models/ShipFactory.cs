namespace FactoryMethodPattern
{
    internal class ShipFactory : TransportationFactory
    {
        public override Transportation Construct()
        {
            return new Ship();
        }
    }
}