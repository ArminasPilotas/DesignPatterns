namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Chain bank -> paypal -> bitcoin
            // if bank can't pay then pay via paypal if paypal can't pay then pay bitcoin
            var bank = new Bank(100);
            var paypal = new Paypal(200);
            var bitcoin = new Bitcoin(300);

            bank.SetNext(paypal);
            paypal.SetNext(bitcoin);

            bank.Pay(260);
        }
    }
}
