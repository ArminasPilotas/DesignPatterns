namespace State
{
    public class UpperCase : IWrittingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToUpper());
        }
    }
}
