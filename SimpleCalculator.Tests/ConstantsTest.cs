using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantsTest
    {
        [TestMethod]
        public void ConstantICanCreateAnInstance()
        {
            // Arrange

            //Act
            Constants my_constants = new Constants();

            //Assert
            Assert.IsNotNull(my_constants);
        }
    }
}
