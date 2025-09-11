namespace Bridge
{
    public class EmailNotifier : INotifier
    {
        public void Send(string to, string message) => Console.WriteLine($"Email to {to}: {message}");
    }
}
