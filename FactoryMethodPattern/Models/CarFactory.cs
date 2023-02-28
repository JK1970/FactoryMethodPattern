namespace FactoryMethodPattern.Models
{
    internal class CarFactory : TransportationFactory
    {
        public override Transportation Construct()
        {
            return new Car();
        }
    }
}