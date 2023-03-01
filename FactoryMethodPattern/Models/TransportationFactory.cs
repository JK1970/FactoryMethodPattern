namespace FactoryMethodPattern.Models
{
    internal abstract class TransportationFactory
    {
        public abstract Transportation Construct();
    }
}