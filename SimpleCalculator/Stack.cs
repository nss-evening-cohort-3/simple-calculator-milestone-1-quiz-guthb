using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {

        //properties
        public string lastCommand { get; set; }
        public string lastAnswer { get; set; }

        public Dictionary<string, int> constantDictionary = new Dictionary<string, int>();
        
    }
}


