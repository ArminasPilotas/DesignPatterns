namespace Bridge
{
    public interface INotifier
    {
        void Send(string to, string message);
    }
}
