namespace FactoryMethodPattern
{
    internal class Ship : Transportation
    {
        public override void Deliver()
        {
            Console.WriteLine("The ship delivered.");
        }
    }
}