using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ModulusTest
    {
        [TestMethod]
        public void ModulusICanCreateAnInstance()
        {
            // Arrange

            //Act
            Modulus func_modu = new Modulus();

            //Assert
            Assert.IsNotNull(func_modu);
        }
    }
}
