using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 23. Series of letters
//Write a program that reads a string from the console and replaces all series
//of consecutive identical letters with a single one.
//
//Example:
//input 	output
//aaaaabbbbbcdddeeeedssaa 	abcdedsa

class SeriesOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        char prevChar = ' ';
        StringBuilder sb = new StringBuilder();
        foreach (char chr in input)
        {
            if (chr != prevChar)
            {
                sb.Append(chr);
                prevChar = chr;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

