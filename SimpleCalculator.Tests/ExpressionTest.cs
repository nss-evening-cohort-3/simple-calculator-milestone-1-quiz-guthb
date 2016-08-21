using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        //can you create a class
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
            Assert.IsFalse(my_expression.validateEnteredStringCheck("1&2"));
        }
  
        [TestMethod]
        //can you validate what was entered was not null
        public void ExpressionIHaveTwoNonNullEntriesAsValues()
        {
            Expression my_expression = new Expression();

            Assert.IsNotNull(my_expression.EnteredValue_One);
            Assert.IsNotNull(my_expression.EnteredOperator);
            Assert.IsNotNull(my_expression.EnteredValue_Two);
        }

        [TestMethod]
        //can you parse two inputs from the string
        public void ExpressionICanParseTwoInputsFromTheString()
        {
            // order of operations + - / % *
            Expression my_expression = new Expression();

            my_expression.parseStringEntered("1+2");
            Assert.AreEqual(1, my_expression.EnteredValue_One);
            Assert.AreEqual(2, my_expression.EnteredValue_Two);

        }

        [TestMethod]
        //can you parse the operator from the string
        public void ExpressionICanParsetheOperatorFromTheString()
        {
            Expression my_expressionAddOperator = new Expression();
            Expression my_expressionSubOperator = new Expression();
            Expression my_expressionDivOperator = new Expression();
            Expression my_expressionModOperator = new Expression();
            Expression my_expressionMulOperator = new Expression();

            my_expressionAddOperator.parseStringEntered("1+2");
            my_expressionSubOperator.parseStringEntered("1-2");
            my_expressionDivOperator.parseStringEntered("1/2");
            my_expressionModOperator.parseStringEntered("1%2");
            my_expressionMulOperator.parseStringEntered("1*2");

            Assert.AreEqual('+', my_expressionAddOperator.EnteredOperator);
            Assert.AreEqual('-', my_expressionSubOperator.EnteredOperator);
            Assert.AreEqual('/', my_expressionDivOperator.EnteredOperator);
            Assert.AreEqual('%', my_expressionModOperator.EnteredOperator);
            Assert.AreEqual('*', my_expressionMulOperator.EnteredOperator);

        }

       [TestMethod]
        //can you parse negative 
        public void ExpressionICanParseNegativeNumbersInTheString()
        {
            Expression my_expressionNegaives = new Expression();
            my_expressionNegaives.parseStringEntered("-1+-2");

            Assert.AreEqual("-1", my_expressionNegaives.EnteredValue_One);
            Assert.AreEqual("-2", my_expressionNegaives.EnteredValue_Two);
            Assert.AreEqual('+', my_expressionNegaives.EnteredOperator);
        }

        [TestMethod]
        public void ExpressionICanParseLargeNumbersFromTheString()
        {
            Expression my_expressionLarge = new Expression();

            my_expressionLarge.parseStringEntered("25+255");

            Assert.AreEqual(25, my_expressionLarge.EnteredValue_One);
            Assert.AreEqual(255, my_expressionLarge.EnteredValue_Two);

        }

    }
}
