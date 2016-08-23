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
        public Expression(Stack myStack)
        {
            my_Stack = myStack;
        }
        //properties of Expression
        public object EnteredValue_One { get; set; }
        public object EnteredValue_Two { get; set; }
        public char EnteredOperator { get; set; }
        public Stack my_Stack { get; set; }

        public string readExpression(string enteredExpression)
        {
            string[] termsArray;
            char[] operatorsArray = new char[] { '+', '-', '/', '%', '*', '=' };

            termsArray = enteredExpression.Split(operatorsArray);

            var operatorValues = Regex.Matches(enteredExpression, @"/+|/-|/\|/%|/*|/=");
           
            return termsArray[0];

        }

        //******trying a different way******//
        // inclue full pattern to handles digits operators and future constants entered
        //Declareations

        //string userInputRegExPattern = @"^(\d*|\w)\s?(\+?\-?\/?\%?\*?)\s?(\d*|\w)$";
        string userInputRegExPattern = @"^((\-?\d+)\s*([\+\-\/\%\*])\s*(\-?\d+))$";
        string constantString = @"^(\s*([A-Za-z])\s*[=]\s*(\-?\d+)\s*)$";
        string constantCalcuationPattern = @"^\s*([A-Za-z\-?\d+])\s*([\+\-\/\%\*])\s*([A-Za-z\-?\d+])$";


        
        //method for checking valid pattern and setting a flag
        public bool validateEnteredStringCheck(string enteredExpression)
        {
            bool returnValue = false;
            
            //if we have a match on first attempt return the value for interagation 
            Match match = Regex.Match(enteredExpression, userInputRegExPattern);
            if (match.Success)
            {
                // Handle match here...
                returnValue = true;
                return returnValue;
            }
            //Check for string entered to set a constant
            match = Regex.Match(enteredExpression, constantString);
            if (match.Success)
            {
                returnValue = true;
            }
            return returnValue; 
        }
        
        // method will parse string if valid
        // parse the value before the operator, the operator and the last value
        // store them 
        // if the string is invalid throw execption
        public void parseStringEntered(string enteredExpression)
        {
            if (validateEnteredStringCheck(enteredExpression))
            {
                //pull out the operator passed in
                Match match = Regex.Match(enteredExpression, userInputRegExPattern);
                char[] operatorsArray = new char[] { '+', '-', '/', '%', '*'};

                if (match.Success)
                {
                    var termsArray = match.Value.Split(operatorsArray);
                    try
                    {
                        //determining the operator
                        char enteredOperator = operatorsArray.SingleOrDefault(calOperator => match.Value.Contains(calOperator));
                       
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
                //check for constant match
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
                //check for constant arithmetic
                match = Regex.Match(enteredExpression, constantCalcuationPattern);
                if (match.Success)
                {
                    var termsArray = match.Value.Split(operatorsArray);
                    try
                    { 
                        //determining the operator
                        char enteredOperator = operatorsArray.SingleOrDefault(calOperator => match.Value.Contains(calOperator));
                        int result1;
                        int result2;
                        //parsing the first digit
                        //check if integer or constant
                        if (!int.TryParse(termsArray[0], out result1) && !my_Stack.constantDictionary.TryGetValue(termsArray[0], out result1))  //yes   integer?
                        {
                            throw new ExpressionException("You did not save a number to the constant in postion one you are attemptign to use.");
                        }

                        var userInputBeforeOperator = result1;                       
                        //parsing the second digit
                        //check if integer or constant
                        if (!int.TryParse(termsArray[1], out result2) && !my_Stack.constantDictionary.TryGetValue(termsArray[1], out result2))  //yes   integer?
                        {
                            throw new ExpressionException("You did not save a number to the constant in position two you are attemptign to use.");
                        }

                        var userInputAfterOperator = result2;
                    
                        //set the values outside the scope
                        EnteredValue_One = userInputBeforeOperator;
                        EnteredValue_Two = userInputAfterOperator;
                        EnteredOperator = enteredOperator;
                    }
                    catch (Exception)
                {
                    throw new ExpressionException("incomplete string entries.");
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
