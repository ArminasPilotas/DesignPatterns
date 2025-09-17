namespace Visitor
{
    public class Dolphin : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Splash splash.");
        }

        public void Accept(IAnimalOperation operation)
        {
            operation.VisitDolphin(this);
        }
    }
}
