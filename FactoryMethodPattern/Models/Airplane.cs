namespace FactoryMethodPattern.Models
{
    internal class Airplane : Transportation
    {
        public override void Deliver()
        {
            Console.WriteLine("The airplane delivered.");
        }
    }
}