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
        public Expression()//constructor best practice
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
        string userInputRegExPattern = @"^(\d*|\w)\s?(\+?\-?\/?\%?\*?)\s?(\d*|\w)$";

        public bool validateEnteredStringCheck(string enteredExpression)
        {
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


        //parsing second attempt
        // method will check to see string is valid
        // if valid parse the value before the operator , the operator and the last value
        // if the string is invalid throw execption
        public void parseStringEntered(string enteredExpression)
        {
            if (validateEnteredStringCheck(enteredExpression))
            {
                //parsing the first digit
                userInputBeforeOperator = Convert.ToInt32();

                //parsing the operator
                userEnteredOperator = Convert.ToChar();

                // parsing the second digit 
                usertInputAfterOperator = Convert.ToInt32();

            }
            else
            {
                //define a new class to be called for the custom exception

            }
           
        
            




        }


        
    }
}
