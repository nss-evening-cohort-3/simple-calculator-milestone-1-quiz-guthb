using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void StackICanCreateAnInstance()
        {
            // Arrange

            //Act
            Stack func_modu = new Stack();

            //Assert
            Assert.IsNotNull(func_modu);
        }
    }
}
