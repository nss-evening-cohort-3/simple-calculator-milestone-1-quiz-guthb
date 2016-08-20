using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        //can i create a class
        public void EvaluateICanCreateAnInstance()
        {
            // Arrange

            //Act
            Evaluate my_eval = new Evaluate();

            //Assert
            Assert.IsNotNull(my_eval);
        }

        [TestMethod]
        //can i perform math operation
        public void EvaluateICanPerformMathmaticalCalculations()
        {

            Evaluate my_eval = new Evaluate();
            Stack new_stack = new Stack();

            my_eval.CurrentStack = new_stack;

            Assert.AreEqual("3", my_eval.EvaluateString(1, 2, '+'));
            Assert.AreEqual("-1", my_eval.EvaluateString(1, 2, '-'));
            Assert.AreEqual("0", my_eval.EvaluateString(1, 2, '/'));
            Assert.AreEqual("1", my_eval.EvaluateString(1, 2, '%'));
            Assert.AreEqual("2", my_eval.EvaluateString(1, 2, '*'));
            
        }
        [TestMethod]
        //can i generate an exception
        [ExpectedException(typeof(ExpressionException))]
        public void EvaluateICanHandleAnInvalidEvaluation()
        {
            Evaluate my_eval = new Evaluate();

            my_eval.EvaluateString(1, 5, '!');
        }

    }
}
