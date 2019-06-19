using System;

namespace Markdown
{
    public class MarkdownBold : MarkdownText
    {
        public MarkdownBold(string markdownText) : base(markdownText)
        {
        }

        public override string ToHTML()
        {
            throw new NotImplementedException();
        }
    }
}