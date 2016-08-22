using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {
        //public Stack CurrentStack { get; set; }

         public string EvaluateString(object EnteredValue_One, object EnteredValue_Two, char EnteredOperator, Stack my_stack)                                
         {
            string answer = "";

             switch (EnteredOperator)
             {
                 case '+':
                     answer = ((int)EnteredValue_One + (int)EnteredValue_Two).ToString();
                     break;
                 case '-':
                     answer = ((int)EnteredValue_One - (int)EnteredValue_Two).ToString();        
                     break;
                 case '/': 
                     answer = ((int)EnteredValue_One / (int)EnteredValue_Two).ToString();
                     break;
                 case '%':                 
                     answer = ((int)EnteredValue_One % (int)EnteredValue_Two).ToString();
                     break;
                 case '*':     
                     answer = ((int)EnteredValue_One * (int)EnteredValue_Two).ToString();
                     break;
                case '=':
                    //string constValueOne = EnteredValue_One.ToString();
                    my_stack.constantDictionary.Add(EnteredValue_One.ToString(), Convert.ToInt32(EnteredValue_Two));
                    answer = "saved " + (string)EnteredValue_One + " as " + (string)EnteredValue_Two;
                    break;
                default:
                     throw new ExpressionException("Evaluate Process Failed.");
              }

            // my_stack.updateStack(EnteredValue_One, EnteredValue_Two, EnteredOperator);
            my_stack.lastAnswer = answer;
            my_stack.lastCommand = EnteredValue_One.ToString() + EnteredOperator.ToString() + EnteredValue_Two.ToString();

            return answer.ToString();
         }



    }
}
  
