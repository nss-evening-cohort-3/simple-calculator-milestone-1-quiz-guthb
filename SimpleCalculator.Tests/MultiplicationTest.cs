using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MuliplicationTest
    {
        [TestMethod]
        public void MuliplicationICanCreateAnInstance()
        {
            // Arrange

            //Act
            Multiplication func_modu = new Multiplication();

            //Assert
            Assert.IsNotNull(func_modu);
        }
    }
}
