namespace Bridge
{
    public class SmsNotifier : INotifier
    {
        public void Send(string to, string message) => Console.WriteLine($"SMS to {to}: {message}");
    }
}
