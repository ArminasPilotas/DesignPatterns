namespace FactoryMethod
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void Pay(Order order) => Console.WriteLine($"Processing card for {order}");
    }
}
