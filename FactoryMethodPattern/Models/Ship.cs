namespace FactoryMethodPattern.Models
{
    internal class Ship : Transportation
    {
        public override void Deliver()
        {
            Console.WriteLine("The ship delivered.");
        }
    }
}