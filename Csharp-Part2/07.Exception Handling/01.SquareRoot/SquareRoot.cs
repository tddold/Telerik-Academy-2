﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Square root
//Write a program that reads an integer number and calculates and prints its square root.
//        If the number is invalid or negative, print Invalid number.
//        In all cases finally print Good bye.
//    Use try-catch-finally block.


class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter integer number");
        
        try
        {
            uint number = uint.Parse(Console.ReadLine());           
            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
        catch  (Exception)
        {
           
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }      
    }
}

