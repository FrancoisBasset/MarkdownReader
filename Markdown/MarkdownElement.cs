using System.Collections.Generic;

namespace Markdown
{
    public abstract class MarkdownElement
    {
        protected string markdownText;
        private List<MarkdownElement> elements;

        public MarkdownElement(string markdownText)
        {
            this.markdownText = markdownText;
            elements = new List<MarkdownElement>();
        }

        public abstract string ToHTML();
    }
}