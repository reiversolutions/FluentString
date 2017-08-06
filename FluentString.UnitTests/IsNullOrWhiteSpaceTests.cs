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
    public class IsNullOrWhiteSpaceTests
    {
        [TestMethod]
        public void Given_A_NullString_IsNullOrWhiteSpace_Is_True()
        {
            // Assign
            string text = null;

            // Act
            var result = text.IsNullOrWhiteSpace();

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_An_EmptyString_IsNullOrWhiteSpace_Is_True()
        {
            // Assign
            string text = string.Empty;

            // Act
            var result = text.IsNullOrWhiteSpace();

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_A_WhiteSpaceString_IsNullOrWhiteSpace_Is_True()
        {
            // Assign
            string text = " ";

            // Act
            var result = text.IsNullOrWhiteSpace();

            // Assert
            result.ShouldBe(true);
        }

        [TestMethod]
        public void Given_A_CleanString_IsNullOrWhiteSpace_Is_False()
        {
            // Assign
            string text = "test";

            // Act
            var result = text.IsNullOrWhiteSpace();

            // Assert
            result.ShouldBe(false);
        }
    }
}
