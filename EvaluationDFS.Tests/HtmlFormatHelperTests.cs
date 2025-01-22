using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EvaluationDFS.Tests
{
    [TestClass]
    public class HtmlFormatHelperTests
    {
        [TestMethod]
        public void GetBoldFormat_InputText_ReturnsBoldHtml()
        {
            // Arrange
            var htmlHelper = new HtmlFormatHelper();
            string input = "Hello";

            // Act
            string result = htmlHelper.GetBoldFormat(input);

            // Assert
            Assert.AreEqual("<b>Hello</b>", result);
        }

        [TestMethod]
        public void GetItalicFormat_InputText_ReturnsItalicHtml()
        {
            // Arrange
            var htmlHelper = new HtmlFormatHelper();
            string input = "Hello";

            // Act
            string result = htmlHelper.GetItalicFormat(input);

            // Assert
            Assert.AreEqual("<i>Hello</i>", result);
        }

        [TestMethod]
        public void GetFormattedListElements_MultipleItems_ReturnsHtmlList()
        {
            // Arrange
            var htmlHelper = new HtmlFormatHelper();
            var items = new List<string> { "Item1", "Item2", "Item3" };

            // Act
            string result = htmlHelper.GetFormattedListElements(items);

            // Assert
            string expectedHtml = "<ul><li>Item1</li><li>Item2</li><li>Item3</li></ul>";
            Assert.AreEqual(expectedHtml, result);
        }

        [TestMethod]
        public void GetFormattedListElements_EmptyList_ReturnsEmptyHtmlList()
        {
            // Arrange
            var htmlHelper = new HtmlFormatHelper();
            var items = new List<string>();

            // Act
            string result = htmlHelper.GetFormattedListElements(items);

            // Assert
            Assert.AreEqual("<ul></ul>", result);
        }
    }
}