using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void DivisionICanCreateAnInstance()
        {
            // Arrange

            //Act
            Division func_div = new Division();

            //Assert
            Assert.IsNotNull(func_div);
        }
    }
}
