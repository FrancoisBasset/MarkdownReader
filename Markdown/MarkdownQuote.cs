namespace Markdown
{
    public class MarkdownQuote : MarkdownText
    {
        public MarkdownQuote(string markdownText) : base(markdownText)
        {
        }

        public override string ToHTML()
        {
            throw new System.NotImplementedException();
        }
    }
}