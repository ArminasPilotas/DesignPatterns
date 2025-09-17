namespace State
{
    public class DefaultText : IWrittingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }
}
