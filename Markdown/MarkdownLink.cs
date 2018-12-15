using System;

namespace Markdown
{
    public class MarkdownLink : MarkdownText
    {
        private int url;

        public MarkdownLink(string markdownText) : base(markdownText)
        {
        }

        public override string ToHTML()
        {
            throw new NotImplementedException();
        }
    }
}