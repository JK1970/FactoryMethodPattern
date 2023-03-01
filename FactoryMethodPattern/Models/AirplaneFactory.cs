namespace FactoryMethodPattern.Models
{
    internal class AirplaneFactory : TransportationFactory
    {
        public override Transportation Construct()
        {
            return new Airplane();
        }
    }
}