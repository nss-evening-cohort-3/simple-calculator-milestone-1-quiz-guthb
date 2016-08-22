using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        //constructor
        public Expression()
        {

        }
        //properties of Expression
        public object EnteredValue_One { get; set; }
        public object EnteredValue_Two { get; set; }
        public char EnteredOperator { get; set; }
  
        public string readExpression(string enteredExpression)
        {
            string[] termsArray;
            char[] operatorsArray = new char[] { '+', '-', '/', '%', '*', '=' };

            termsArray = enteredExpression.Split(operatorsArray);

            var operatorValues = Regex.Matches(enteredExpression, @"/+|/-|/\|/%|/*|/=");
           
            return termsArray[0];

            //got to this point but do not understand how to us IEnumerable<>to capture array of values and operators
        }

        //******trying a different way******//
        // inclue full pattern to handles digits operators and future constants entered
        //Declareations

        //string userInputRegExPattern = @"^(\d*|\w)\s?(\+?\-?\/?\%?\*?)\s?(\d*|\w)$";
        string userInputRegExPattern = @"^((\-?\d+)\s*([\+\-\/\%\*])\s*(\-?\d+))$";
        string constantString = @"^(\s*([A-Za-z])\s*[=]\s*(\-?\d+)\s*)$";

        //parsing second attempt
        //method for checking valid pattern
        public bool validateEnteredStringCheck(string enteredExpression)
        {
            bool returnValue = false;
            //may need to add a switch statement here for the quit and exit before the match

            Match match = Regex.Match(enteredExpression, userInputRegExPattern);
            if (match.Success)
            {
                // Handle match here...
                returnValue = true;
                return returnValue;
            }
            match = Regex.Match(enteredExpression, constantString);
            if (match.Success)
            {
                returnValue = true;
            }
            return returnValue; 
        }
        
        // method will check to see string is valid
        // if valid parse the value before the operator, the operator and the last value
        // store them as
        // if the string is invalid throw execption
        public void parseStringEntered(string enteredExpression)
        {
            if (validateEnteredStringCheck(enteredExpression))
            {

                Match match = Regex.Match(enteredExpression, userInputRegExPattern);
                char[] operatorsArray = new char[] { '+', '-', '/', '%', '*'};

                if (match.Success)
                {
                    var termsArray = match.Value.Split(operatorsArray);
                    try
                    {
                        //determining the operator
                        char enteredOperator = operatorsArray.SingleOrDefault(calOperator => match.Value.Contains(calOperator));
                        // Console.WriteLine(enteredOperator);

                        //parsing the first digit
                        var userInputBeforeOperator = Convert.ToInt32(termsArray[0]);

                        // parsing the second digit 
                        var usertInputAfterOperator = Convert.ToInt32(termsArray[1]);

                        //set the values outside the scope
                        EnteredValue_One = userInputBeforeOperator;
                        EnteredValue_Two = usertInputAfterOperator;
                        EnteredOperator = enteredOperator;
                    }
                    catch (Exception)
                    {
                        throw new ExpressionException("incomplete string entries.");
                    }
                }
                match = Regex.Match(enteredExpression, constantString);
                if (match.Success)             
                {
                    var constantArray = match.Value.Split('=');
                    try
                    {
                        char enteredOperator = '=';
                        var userInputBeforeOperator = (constantArray[0]);
                        var userInputAfterOperator = (constantArray[1]);
                        EnteredValue_One = userInputBeforeOperator;
                        EnteredValue_Two = userInputAfterOperator;
                        EnteredOperator = enteredOperator;

                    }
                    catch(Exception)
                    {
                        throw new ExpressionException("something was entered incorrectly.");
                    }
                }

            }
            else
            {
                //define a new class to be called for the custom exception
                throw new ExpressionException("Entered string is not allowed.");
            }
    
        }


        
    }
}
