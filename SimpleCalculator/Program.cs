﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression myExpression = new Expression();

            Console.Write("[0]>");
            var userEntered = Console.ReadLine();
            if (myExpression.validateEnteredStringCheck(userEntered))
            {
                myExpression.parseStringEntered(userEntered);
            }
            Console.ReadKey();    

        }
    }
}
