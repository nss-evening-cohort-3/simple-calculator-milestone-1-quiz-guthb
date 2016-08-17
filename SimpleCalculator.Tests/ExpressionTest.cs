using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void ExpresssionICanCreateAnInstance()
        {
            // Arrange

            //Act
            Expression my_expression = new Expression();

            //Assert
            Assert.IsNotNull(my_expression);
        }
    }
}
