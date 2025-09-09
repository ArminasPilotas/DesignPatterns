namespace FactoryMethod
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public void Pay(Order order) => Console.WriteLine($"Processing PayPal for {order}");
    }
}
