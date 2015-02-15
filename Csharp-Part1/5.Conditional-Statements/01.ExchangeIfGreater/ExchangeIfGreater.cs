using System;

//Problem 1. Exchange If Greater
//Write an if-statement that takes two double variables a and b and exchanges their values 
//if the first one is greater than the second one. As a result print the values a and b, separated by a space.
//Examples:
//a 	b 	result
//5 	2 	2 5
class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            double c = b;
            b = a;
            a = c;
            Console.WriteLine("The first one is bigger than the second one, so their values are switched");
            Console.WriteLine(a + " " + b);
        }
        else
        {
            Console.WriteLine("The first one is smaller or equal to the second one, so their values are NOT switched");
            Console.WriteLine(a + " " + b);
        }
    }
}
