using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 17. Date in Bulgarian
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) 
//along with the day of week in Bulgarian.


class DateInBulgarian
{
    static void Main()
    {
        string inputDate = Console.ReadLine();
        string[] separation = inputDate.Split(' ');       
        int[] date =separation[0].Split('.').Select(n=>Convert.ToInt32(n)).ToArray();
        int[] time = separation[1].Split(':').Select(n => Convert.ToInt32(n)).ToArray();
        DateTime dateForCalculation;
        try 
        { 
        dateForCalculation = new DateTime(date[2], date[1], date[0], time[0], time[1], time[2]);
        }     catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid date!");
            return;
        }
        dateForCalculation= dateForCalculation.AddHours(6).AddMinutes(30); 

        var culture = new CultureInfo("bg-BG");
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine(dateForCalculation.ToString(culture));
        Console.WriteLine(culture.DateTimeFormat.GetDayName(dateForCalculation.DayOfWeek));
    }
}

