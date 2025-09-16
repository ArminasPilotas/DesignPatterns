namespace Memento
{
    public class EditorMemento
    {
        private string mContent;

        public EditorMemento(string content)
        {
            mContent = content;
        }

        public string Content
        {
            get
            {
                return mContent;
            }
        }
    }
}
