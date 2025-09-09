namespace FactoryMethod
{
    internal class PayPalFactory : PaymentFactory
    {
        public override IPaymentProcessor Create() => new PayPalProcessor();
    }
}
