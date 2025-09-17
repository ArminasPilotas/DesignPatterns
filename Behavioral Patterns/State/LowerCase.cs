namespace State
{
    public class LowerCase : IWrittingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }
}
