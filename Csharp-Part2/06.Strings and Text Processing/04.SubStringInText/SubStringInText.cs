using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
////The result is: 9
class SubStringInText
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the substring which will be searched at the text:");
        string searchedText= Console.ReadLine();
        int count = Regex.Matches(input, searchedText).Count;
        Console.WriteLine("The count of occurencies of the searched sub string in the text is:");
        Console.WriteLine(count);
    }
}

