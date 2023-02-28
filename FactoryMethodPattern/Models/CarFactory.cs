namespace FactoryMethodPattern
{
    internal class CarFactory : TransportationFactory
    {
        public override Transportation Construct()
        {
            return new Car();
        }
    }
}