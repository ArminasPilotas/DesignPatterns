namespace Observer
{
    public class JobPost
    {
        public string Title { get; private set; }

        public JobPost(string title)
        {
            Title = title;
        }
    }
}
