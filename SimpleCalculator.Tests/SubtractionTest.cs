using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public void SubtractionICanCreateAnInstance()
        {
            // Arrange

            //Act
            Subtraction func_modu = new Subtraction();

            //Assert
            Assert.IsNotNull(func_modu);
        }
    }
}
