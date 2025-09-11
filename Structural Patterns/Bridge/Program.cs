namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var email = new OrderNotification(new EmailNotifier());
            email.OrderPlaced("email@example.com");
            var sms = new OrderNotification(new SmsNotifier());
            sms.OrderPlaced("+41060000000");
        }
    }
}
