using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        //can i create a class
        public void StackICanCreateAnInstance()
        {
            // Arrange

            //Act
            Stack func_stack = new Stack();

            //Assert
            Assert.IsNotNull(func_stack);
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
        


    }
}
