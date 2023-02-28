namespace FactoryMethodPattern
{
    internal class AirplaneFactory : TransportationFactory
    {
        public override Transportation Construct()
        {
            return new Airplane();
        }
    }
}