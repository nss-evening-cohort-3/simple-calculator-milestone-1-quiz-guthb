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
        //can i set the capture the answer
        public void StackICanCaptureAnswer()
            
        {
            Stack func_stack = new Stack();

            string test_lastq = "1+2";  //last command
            string test_last = "3"; //last answer

            //func_stack.updateStack(1, 2, '+');
            Evaluate eval_stack = new Evaluate();
            eval_stack.EvaluateString(1,2,'+', func_stack);

            Assert.AreEqual(func_stack.lastCommand, test_lastq);
            Assert.AreEqual(func_stack.lastAnswer, test_last);



        }
        


    }
}
