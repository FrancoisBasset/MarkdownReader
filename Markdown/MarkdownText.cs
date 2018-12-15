namespace Markdown
{
    public abstract class MarkdownText : MarkdownElement
    {
        private string text;

        public MarkdownText(string markdownText) : base(markdownText)
        {

        }
    }
}