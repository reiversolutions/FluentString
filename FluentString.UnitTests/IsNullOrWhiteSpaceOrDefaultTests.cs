using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentString.UnitTests
{
    [TestClass]
    public class IsNullOrWhiteSpaceOrDefaultTests
    {
        [TestMethod]
        public void Given_A_NullString_IsNullOrWhiteSpaceOrDefault_Is_True()
        {
            // Assign
            string text = null;

            // Act
            var result = text.IsNullOrWhiteSpaceOrDefault(string.Empty);

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_An_EmptyString_IsNullOrWhiteSpaceOrDefault_Is_True()
        {
            // Assign
            string text = string.Empty;

            // Act
            var result = text.IsNullOrWhiteSpaceOrDefault(string.Empty);

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_A_WhiteSpaceString_IsNullOrWhiteSpaceOrDefault_Is_True()
        {
            // Assign
            string text = " ";

            // Act
            var result = text.IsNullOrWhiteSpaceOrDefault(string.Empty);

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_A_String_Matching_The_Default_IsNullOrWhiteSpaceOrDefault_Is_True()
        {
            // Assign
            string defaultText = "default";
            string text = defaultText;

            // Act
            var result = text.IsNullOrWhiteSpaceOrDefault(defaultText);

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_A_CleanString_IsNullOrWhiteSpaceOrDefault_Is_False()
        {
            // Assign
            string text = "test";

            // Act
            var result = text.IsNullOrWhiteSpaceOrDefault(string.Empty);

            // Assert
            result.ShouldBe(false);
        }

        [TestMethod]
        public void Given_A_CleanString_Not_Matching_TheDefault_IsNullOrWhiteSpaceOrDefault_Is_False()
        {
            // Assign
            string defaultText = "default";
            string text = "test";

            // Act
            var result = text.IsNullOrWhiteSpaceOrDefault(defaultText);

            // Assert
            result.ShouldBe(false);
        }
    }
}
