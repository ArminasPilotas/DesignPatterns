namespace Bridge
{
    public class OrderNotification
    {
        protected INotifier notifier;
        public OrderNotification(INotifier impl) => notifier = impl;
        public virtual void Notify(string user, string msg) => notifier.Send(user, msg);
        public void OrderPlaced(string user) => Notify(user, "Your order was placed");
    }
}
