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

         public string EvaluateString(int EnteredValue_One, int EnteredValue_Two, char EnteredOperator, Stack my_stack)                                
         {
             int answer;

             switch (EnteredOperator)
             {
                 case '+':
                     answer = EnteredValue_One + EnteredValue_Two;
                     break;
                 case '-':
                     answer = EnteredValue_One - EnteredValue_Two;        
                     break;
                 case '/': 
                     answer = EnteredValue_One / EnteredValue_Two;
                     break;
                 case '%':                 
                     answer = EnteredValue_One % EnteredValue_Two;
                     break;
                 case '*':     
                     answer = EnteredValue_One * EnteredValue_Two;
                     break;
                 default:
                     throw new ExpressionException("Evaluate Process Failed.");
              }

            // my_stack.updateStack(EnteredValue_One, EnteredValue_Two, EnteredOperator);
            my_stack.lastAnswer = answer.ToString();
            my_stack.lastCommand = EnteredValue_One.ToString() + EnteredOperator.ToString() + EnteredValue_Two.ToString();

            return answer.ToString();
         }



    }
}
  
