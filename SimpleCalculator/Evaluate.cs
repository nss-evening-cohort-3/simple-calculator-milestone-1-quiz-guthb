﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Evaluate
    {

         public string EvaluateString(int EnteredValue_One, int EnteredValue_Two, char EnteredOperator)                                
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
             return answer.ToString();
         }

    }
}
  
