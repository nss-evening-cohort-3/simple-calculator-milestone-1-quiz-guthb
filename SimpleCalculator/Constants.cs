using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    public class Constants
    {

        string newConstant;
        int newInteger;
        string constantString = @"^(\s*([A-Za-z])\s*[=]\s*(\-?\d+)\s*)S";
        
        Dictionary<string, int> dictionary = new Dictionary<string, int>();


        public bool validateConstantStringCheck(string enteredExpression)
        {

            //may need to add a switch statement here for the quit and exit before the match

            Match match = Regex.Match(enteredExpression, constantString);
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
    }
}
