using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string[] separators = new string[] { " "};
        string[] words = input.Split(separators,
            StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words, (x, y) => String.Compare(x, y));
        Console.WriteLine(string.Join((", "), words));
    }
}

