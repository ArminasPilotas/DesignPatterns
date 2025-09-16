namespace Observer
{
    public class JobPostings : IObservable<JobPost>
    {
        private List<IObserver<JobPost>> Observers;
        private List<JobPost> JobPostingsList;

        public JobPostings()
        {
            Observers = new List<IObserver<JobPost>>();
            JobPostingsList = new List<JobPost>();
        }

        public IDisposable Subscribe(IObserver<JobPost> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
            return new Unsubscriber<JobPost>(Observers, observer);
        }

        private void Notify(JobPost jobPost)
        {
            foreach (var observer in Observers)
            {
                observer.OnNext(jobPost);
            }
        }

        public void AddJob(JobPost jobPost)
        {
            JobPostingsList.Add(jobPost);
            Notify(jobPost);
        }
    }
}
