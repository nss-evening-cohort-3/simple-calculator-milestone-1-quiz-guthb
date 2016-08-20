using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        string lastCommand { get; set; }
        string lastAnswer { get; set; }

        public void updateStack(int valueOne, int valueTwo, char operatorValue)
        {

            Evaluate mybrainhurts = new Evaluate();
            lastAnswer = mybrainhurts.EvaluateString(valueOne, valueTwo, operatorValue);
            lastCommand = valueOne.ToString() + operatorValue.ToString() + valueTwo.ToString();
 
        }


    }
}


