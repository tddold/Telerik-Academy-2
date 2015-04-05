//Problem 17. Longest string
//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.


namespace longest
{
    using System;
    using System.Linq;
    class LongestString
    {
        static void Main()
        {
            string[] arrayOfString = { "aaa", "bbbbbb", "cc", "dddd" };
            string longest = (from str in arrayOfString
                              orderby str.Length descending
                              select str).First();
            Console.WriteLine("The longest string in the array is:");
            Console.WriteLine(longest);
        }
    }
}
