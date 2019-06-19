using System;

namespace Markdown
{
    public class MarkdownItalic : MarkdownText
    {
        public MarkdownItalic(string markdownText) : base(markdownText)
        {
        }

        public override string ToHTML()
        {
            throw new NotImplementedException();
        }
    }
}