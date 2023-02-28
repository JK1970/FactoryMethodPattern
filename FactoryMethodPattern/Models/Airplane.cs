namespace FactoryMethodPattern
{
    internal class Airplane : Transportation
    {
        public override void Deliver()
        {
            Console.WriteLine("The airplane delivered.");
        }
    }
}