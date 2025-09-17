namespace State
{
    public class TextEditor
    {
        private IWrittingState writtingState;

        public TextEditor()
        {
            writtingState = new DefaultText();
        }

        public void SetState(IWrittingState state)
        {
            writtingState = state;
        }

        public void Type(string words)
        {
            writtingState.Write(words);
        }
    }
}
