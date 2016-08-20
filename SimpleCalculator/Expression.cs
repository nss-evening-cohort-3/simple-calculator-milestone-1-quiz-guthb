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

        public string readExpression(string enteredExpression)
        {
            string[] termsArray;
            char[] operatorsArray = new char[] { '+', '-', '/', '%', '*' };

            termsArray = enteredExpression.Split(operatorsArray);

            var operatorValues = Regex.Matches(enteredExpression, @"/+|/-|/\|/%|/*");
           
            return termsArray[0];

            //got to this point but do not understand how to us IEnumerable<>to capture array of values and operators
        }

        //******trying a different way******//
        // inclue full pattern to handles digits operators and future constants entered
        //Declareations

        string userInputRegExPattern = @"^(\d*|\w)\s?(\+?\-?\/?\%?\*?)\s?(\d*|\w)$";
        public int EnteredValue_One { get; set; }
        public int EnteredValue_Two { get; set; }
        public char EnteredOperator { get; set; }


        //parsing second attempt
        //method for checking valid pattern
        public bool validateEnteredStringCheck(string enteredExpression)
        {

            //may need to add a switch statement here for the quit and exit before the match

            Match match = Regex.Match(enteredExpression, userInputRegExPattern);
            if (match.Success)
            {
                // Handle match here...
                return true;
            }
            else
            {
                // Handle no match here...
                return false;   
            }    
            
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
                char[] operatorsArray = new char[] { '+', '-', '/', '%', '*' };
                
                var termsArray = match.Value.Split(operatorsArray);
                //  Console.WriteLine(match.Value);
                // Console.WriteLine(termsArray[0]);
                // Console.WriteLine(termsArray[1]);
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
            else
            {
                //define a new class to be called for the custom exception
                throw new ExpressionException("Entered string is not allowed.");
            }
    
        }


        
    }
}
