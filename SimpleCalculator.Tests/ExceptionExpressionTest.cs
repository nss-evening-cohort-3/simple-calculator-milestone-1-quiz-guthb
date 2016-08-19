using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExceptionExpressionTest
    {
        [TestMethod]
        //can you generate a custom exception for a invalid string
        [ExpectedException(typeof(ExpressionException))]
        public void invalidStringThrowsExecption()
        {
            Expression my_expression = new Expression();

            my_expression.parseStringEntered("?+!");
        }

        [TestMethod]
        //can you generate a custom exception on incorrect operation
        [ExpectedException(typeof(ExpressionException))]
        public void invalidOperatorThrowsExecption()
        {
            Expression my_expression = new Expression();

            my_expression.parseStringEntered("1!2");
        }

        [TestMethod]
        //can you generate a custom exception for incomplete string
        [ExpectedException(typeof(ExpressionException))]
        public void incompleteStringThrowsExecption()
        {
            Expression my_expression = new Expression();

            my_expression.parseStringEntered("1+");
        }

        [TestMethod]
        //can you generate a custom exception for incomplete string with missing first digit 
        [ExpectedException(typeof(ExpressionException))]
        public void incompleteString2ThrowsExecption()
        {
            Expression my_expression = new Expression();

            my_expression.parseStringEntered(" +2");
        }

        [TestMethod]
        //can you generate a custom exception for incomplete string with one value
        [ExpectedException(typeof(ExpressionException))]
        public void incompleteString3ThrowsExecption()
        {
            Expression my_expression = new Expression();

            my_expression.parseStringEntered("1");
        }        
    }
}