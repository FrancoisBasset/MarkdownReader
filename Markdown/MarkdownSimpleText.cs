using System;

namespace Markdown
{
    public class MarkdownSimpleText : MarkdownText
    {
        public MarkdownSimpleText(string markdownText) : base(markdownText)
        {
        }

        public override string ToHTML()
        {
            throw new NotImplementedException();
        }
    }
}