namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rickyRock = new JobSeeker("Ricky Rock");
            var johnJohnson = new JobSeeker("John Johnson");

            var jobPostings = new JobPostings();
            jobPostings.Subscribe(rickyRock);
            jobPostings.Subscribe(johnJohnson);

            jobPostings.AddJob(new JobPost("Software Engineer"));
        }
    }
}
