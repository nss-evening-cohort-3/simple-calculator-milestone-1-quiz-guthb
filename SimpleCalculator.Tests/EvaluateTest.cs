using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void EvaluateICanCreateAnInstance()
        {
            // Arrange

            //Act
            Evaluate my_eval = new Evaluate();

            //Assert
            Assert.IsNotNull(my_eval);
        }
    }
}
