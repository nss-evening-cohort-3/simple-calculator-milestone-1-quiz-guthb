using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        // can you create a class
        public void ExpresssionICanCreateAnInstance()
        {
            // Arrange

            //Act
            Expression my_expression = new Expression();

            //Assert
            Assert.IsNotNull(my_expression);
        }

        [TestMethod]
        //can you read a string
        public void ExpressionIcanReadAString()
        {
            Expression my_expression = new Expression();

            Assert.IsNotNull(my_expression.readExpression("test"));

        }


        [TestMethod]
        //can you parse from a string up to the operator char
        public void ExpressionIcanParseAString()
        {
            Expression my_expression = new Expression();

            Assert.IsTrue( "12345" == my_expression.readExpression("12345+67890"));

        }

        [TestMethod]
        //can you accept a valid string against regex pattern for valid entry
        public void ExpressionIsAnAcceptedString()
        {
            Expression my_expression = new Expression();

            // order of operations + - / % *

            Assert.IsTrue(my_expression.validateEnteredStringCheck("1+2"));
            Assert.IsTrue(my_expression.validateEnteredStringCheck("1-2"));
            Assert.IsTrue(my_expression.validateEnteredStringCheck("1/2"));
            Assert.IsTrue(my_expression.validateEnteredStringCheck("1%2"));
            Assert.IsTrue(my_expression.validateEnteredStringCheck("1*2"));

            // invalid inputs
            Assert.IsFalse(my_expression.validateEnteredStringCheck(" 1+2"));
            Assert.IsFalse(my_expression.validateEnteredStringCheck("1+2 "));
        }
        


    }
}
