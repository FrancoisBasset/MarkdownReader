using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Markdown.Tests
{
    [TestClass]
    public class MarkdownSimpleTextTests
    {

        [TestMethod]
        public void ToHTMLTest()
        {
            string markdownText = "a";

            MarkdownSimpleText markdownSimpleText = new MarkdownSimpleText(markdownText);

            Assert.AreEqual(markdownText, markdownSimpleText.ToHTML());
        }
    }
}