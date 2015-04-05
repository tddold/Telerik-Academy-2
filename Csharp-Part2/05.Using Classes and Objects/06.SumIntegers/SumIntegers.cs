using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6. Sum integers
//
//    You are given a sequence of positive integer values written into a string, separated by spaces.
//    Write a function that reads these values from given string and calculates their sum.
//
//Example:
//input 	output
//"43 68 9 23 318" 	461

class SumIntegers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers:");
        string input = Console.ReadLine();
        string[] arrayOfStrings = input.Split(' ');       
        int sum = 0;
        for (int i = 0; i < arrayOfStrings.Length; i++)
        {
            int number = int.Parse(arrayOfStrings[i]);
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is:");
        Console.WriteLine(sum);
    }
}

