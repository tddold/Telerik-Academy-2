using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 1. Leap year
//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

class LeapYear
{
    static void Main()
    {
        DateTime date = DateTime.Parse(Console.ReadLine());
       if (DateTime.IsLeapYear(date.Year))
       {
           Console.WriteLine("{0} is leap year.",date.Year);
       }
       else
       {
           Console.WriteLine("{0} is not leap year.",date.Year);
       }
    }
}
