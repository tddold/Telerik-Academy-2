using System;

class CurrentDateAndTime
{
    static void Main()
    {
        Console.WriteLine("Your birth date:");
        string input = Console.ReadLine();
        DateTime birthDate = DateTime.Parse(input);
        int Age = DateTime.Now.Year - birthDate.Year - (DateTime.Now.DayOfYear < birthDate.DayOfYear ? 1 : 0);
        Console.WriteLine("Current age {0}",Age);
        Console.WriteLine("Age after 10 years: {0}", Age+10);
    }
}