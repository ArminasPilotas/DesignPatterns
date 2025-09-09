namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order { Id = 101, Amount = 33.41m };
            PaymentFactory factory = new CreditCardFactory();
            factory.Process(order);

            factory = new PayPalFactory();
            factory.Process(order);
        }
    }
}
