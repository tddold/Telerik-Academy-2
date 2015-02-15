using System;
//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.
//Examples:
//a 	b 	c 	d 	e 	biggest
//5 	2 	2 	4 	1 	5

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        double biggest = a;
        Console.WriteLine("The biggest number is:");
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(biggest);
        }
        else if (b > a && b >= c && b >= d && b >= e)
        {
            biggest = b;
            Console.WriteLine(biggest);
        }
        else if (c > a && c > b && c >= d && c >= e)
        {
            biggest = c;
            Console.WriteLine(biggest);
        }
        else if (d > a && d > b && d > c && d >= e)
        {
            biggest = d;
            Console.WriteLine(biggest);
        }
        else if (e > a && e > b && e > c && e > d)
        {
            biggest = e;
            Console.WriteLine(biggest);
        }
    }
}
