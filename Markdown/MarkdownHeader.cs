using System;

namespace Markdown
{
    public class MarkdownHeader : MarkdownText
    {
        private short headerLevel;

        public MarkdownHeader(string markdownText) : base(markdownText)
        {
        }

        public override string ToHTML()
        {
            throw new NotImplementedException();
        }
    }
}