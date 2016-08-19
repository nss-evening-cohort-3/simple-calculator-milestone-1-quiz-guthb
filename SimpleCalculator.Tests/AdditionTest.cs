using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void AdditionICanCreateAnInstance()
        {
            // Arrange

            //Act
            Addition  func_add = new Addition();

            //Assert
            Assert.IsNotNull(func_add);
        }

    }
}
