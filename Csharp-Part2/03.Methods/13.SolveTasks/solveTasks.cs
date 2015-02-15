﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 13. Solve tasks
//Write a program that can solve these tasks:
//    Reverses the digits of a number
//    Calculates the average of a sequence of integers
//    Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//    The decimal number should be non-negative
//    The sequence should not be empty
//    a should not be equal to 0


class solveTasks
{
    static void Main()
    {
        Console.WriteLine("Choose task");
        Console.WriteLine("1.Reverses the digits of a number");
        Console.WriteLine("2.Calculates the average of a sequence of integers");
        Console.WriteLine("3.Solves a linear equation a * x + b = 0");
        bool isNot123 = true;
        while (isNot123 == true)
        {
            int task = int.Parse(Console.ReadLine());
            if (task > 3 || task < 0)
            {
                Console.WriteLine("You didn't choose option. Please try again");
            }
            else
            {
                if (task == 1)
                {
                    int reversed=reverse();
                    isNot123 = false;
                    Console.WriteLine("The reversed number is {0}",reversed);
                }
                else if (task == 2)
                {
                    double average= calcAverage();
                    isNot123 = false;
                    Console.WriteLine("The average number is {0}", average);
                }
                else if (task == 3)
                {
                    double x = calcEquation();
                    isNot123 = false;
                    Console.WriteLine("X is {0}", x);
                }
            }
        }
    }
    static int reverse()
    {
        int forReversing = 0;
        bool isNegative = true;
        Console.WriteLine("Enter number for reversing:");
        while (isNegative)
        {
            forReversing = int.Parse(Console.ReadLine());
            if (forReversing <= 0)
            {
                Console.WriteLine("Please enter positive number");
            }
            else
            {
                isNegative = false;
            }
        }
        char[] digits = forReversing.ToString().ToCharArray();       
        int intResult = 0; ;
        for (int i = 0; i < digits.Length / 2; i++)
        {
            char temp = digits[i];
            digits[i] = digits[digits.Length - 1 - i];
            digits[digits.Length - 1 - i] = temp;                 
        }
        return intResult = int.Parse(string.Join("", digits));
    }

    static double calcAverage()
    {
        bool isNotEnd = true;
        Console.WriteLine("Enter sequence of numbers or \"end\" to finish the task.");
        List<int> listOfInts = new List<int>();
        while (isNotEnd)
        {
            int numeric;
            string number = Console.ReadLine();
            if (number == "end")
            {
                isNotEnd = false;
                break;
            }
            bool isNumeric = int.TryParse(number, out numeric);
            if (isNumeric == false)
            {
                Console.WriteLine("Please try again to enter a valid number for the sequence");
            }
            else
            {
                listOfInts.Add(numeric);
            }
        }
        double sum = 0;
        for (int i = 0; i < listOfInts.Count; i++)
        {
            sum += listOfInts[i];
        }
        double average = sum / (listOfInts.Count);
        return average;
    }
    static double calcEquation()
    {
        int numericA = 0;
        int numericB = 0;
        bool isNumberA = false;
        bool isNumberB = false;
        Console.WriteLine("Please enter number for a:");
        while (isNumberA==false)
        {
            string inputA = Console.ReadLine();
            isNumberA = int.TryParse(inputA, out numericA);
            if (isNumberA == false || numericA == 0)
            {
                isNumberA = false;
                Console.WriteLine("Please try again to enter a valid number not equal to 0");
            }
            else
            {
                isNumberA = true;
            }
        }
        Console.WriteLine("Please enter number for b:");
        while (isNumberB == false)
        {
            string inputB = Console.ReadLine();
            isNumberB = int.TryParse(inputB, out numericB);
            if (isNumberB == false)
            {
                Console.WriteLine("Please try again to enter a valid number B");
            }
            else
            {
                isNumberB = true;
            }
        }
        double result = -numericB / (double)numericA;
        return result;
    }
}

