namespace FactoryMethod
{
    internal class CreditCardFactory : PaymentFactory
    {
        public override IPaymentProcessor Create() => new CreditCardProcessor();
    }
}
