using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 16. Date difference
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days


class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date:");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date:");
        string secondDate = Console.ReadLine();
        string[] firstDateArray = firstDate.Split('.');
        DateTime firstDateFormatted=new DateTime(int.Parse(firstDateArray[2]),int.Parse(firstDateArray[1]),int.Parse(firstDateArray[0]));
        string[] secondDateArray = secondDate.Split('.');
        DateTime secondDateFormatted = new DateTime(int.Parse(secondDateArray[2]), int.Parse(secondDateArray[1]), int.Parse(secondDateArray[0]));
        TimeSpan diff = secondDateFormatted - firstDateFormatted;
        Console.WriteLine("Distance: {0} days",diff.Days);
    }
}

