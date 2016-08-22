using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression myExpression = new Expression();
            Stack myStack = new Stack();
            Evaluate myEvaluate = new Evaluate();
            int operation_counter = 0;

            //Repeats until user quits.
            bool running = true;
            while (running)
            {
                Console.Write("["+operation_counter.ToString()+"]> ");
                var userEntered = Console.ReadLine();
                

                //check input for 
                switch (userEntered)
                {
                    case "quit":
                    case "exit":
                    {
                        Console.WriteLine("Bye!!");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    }
                    case "last":
                    {
                        Console.WriteLine(myStack.lastAnswer);
                        break;
                    }
                    case "lastq":
                    {
                        Console.WriteLine(myStack.lastCommand);
                        break;
                    }
                    default:
                        if (myExpression.validateEnteredStringCheck(userEntered))
                        {
                            myExpression.parseStringEntered(userEntered);
                            Console.WriteLine("   = "+myEvaluate.EvaluateString(myExpression.EnteredValue_One, myExpression.EnteredValue_Two, myExpression.EnteredOperator, myStack));
                        }
                        else
                        {
                            Console.Write("That is not a valid entry, Please Try Again.");
                        }

                        Console.WriteLine();
                        break;
                     }

                operation_counter ++;


                /*string commandInput = Console.ReadLine();
                
                if (myExpression.validateEnteredStringCheck(userEntered))
                {
                    myExpression.parseStringEntered(userEntered);
                }*/

            }
              Console.ReadKey();    

        }
    }
}
