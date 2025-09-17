namespace Visitor
{
    public interface IAnimal
    {
        void Accept(IAnimalOperation operation);
    }
}
