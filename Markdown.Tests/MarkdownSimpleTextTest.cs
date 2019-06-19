// <copyright file="MarkdownSimpleTextTest.cs">Copyright ©  2018</copyright>
using System;
using Markdown;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Markdown.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour MarkdownSimpleText</summary>
    [PexClass(typeof(MarkdownSimpleText))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MarkdownSimpleTextTest
    {
        /// <summary>Stub de test pour .ctor(String)</summary>
        [PexMethod]
        public MarkdownSimpleText ConstructorTest(string markdownText)
        {
            MarkdownSimpleText target = new MarkdownSimpleText(markdownText);
            return target;
            // TODO: ajouter des assertions à méthode MarkdownSimpleTextTest.ConstructorTest(String)
        }

        /// <summary>Stub de test pour ToHTML()</summary>
        [PexMethod]
        public string ToHTMLTest([PexAssumeUnderTest]MarkdownSimpleText target)
        {
            string result = target.ToHTML();
            return result;
            // TODO: ajouter des assertions à méthode MarkdownSimpleTextTest.ToHTMLTest(MarkdownSimpleText)
        }
    }
}
