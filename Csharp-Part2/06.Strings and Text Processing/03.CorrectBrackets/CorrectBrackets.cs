using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3. Correct brackets
//Write a program to check if in a given expression the brackets are put correctly.
//
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

class CorrectBrackets
{
    static void Main()
    {
        Console.WriteLine("Enter math expression:");
        string input = Console.ReadLine();
        bool incorrect = false;
        int countLeftPar = input.Split('(').Length - 1;
        int countRightPar = input.Split(')').Length - 1;
        if (countLeftPar != countRightPar)
        {
            incorrect = true;
        }

        
    }
}

