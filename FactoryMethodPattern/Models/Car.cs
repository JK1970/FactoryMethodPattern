namespace FactoryMethodPattern
{
    internal class Car : Transportation
    {
        public override void Deliver()
        {
            Console.WriteLine("The car delivered.");
        }
    }
}