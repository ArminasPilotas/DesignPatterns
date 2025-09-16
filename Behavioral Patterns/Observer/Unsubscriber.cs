namespace Observer
{
    public class Unsubscriber<JobPost> : IDisposable
    {
        private List<IObserver<JobPost>> Observers;
        private IObserver<JobPost> Observer;

        internal Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
        {
            this.Observers = observers;
            this.Observer = observer;
        }

        public void Dispose()
        {
            if (Observers.Contains(Observer))
            {
                Observers.Remove(Observer);
            }
        }
    }
}
