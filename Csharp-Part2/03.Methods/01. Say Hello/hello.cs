using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 1. Say Hello
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//
//Example:
//input 	output
//Peter 	Hello, Peter!
class hello
{
    static void Main()
    {
        string input=say();
        stringCheck(input);
    }
    public static string say()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    public static void stringCheck(string check)
    {
        int coundOfValidLetters = Regex.Matches(check, @"[a-zA-Z]").Count;
        if (coundOfValidLetters==check.Length)
        {
            Console.WriteLine("Hello, {0}!", check);
        }
        else
        {
            Console.WriteLine("Not a valid name.");
        }
    }
}

