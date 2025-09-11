namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new Order(29.99m);
            order = new GiftWrapDecorator(order);
            order = new ExpressDecorator(order);
            Console.WriteLine($"{order.Description()} -> ${order.Total()}");
        }
    }
}
