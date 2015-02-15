using System;
//Problem 5. The Biggest of 3 Numbers
//Write a program that finds the biggest of three numbers.
//Examples:
//a 	b 	c 	biggest
//5 	2 	2 	5
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double biggest = a;
        Console.WriteLine("The biggest number is:");
        if (a >= b && a >= c)
        {
            Console.WriteLine(biggest);
        }
        else if (b > a && b >= c)
        {
            biggest = b;
            Console.WriteLine(biggest);
        }
        else if (c > b && c > a)
        {
            biggest = c;
            Console.WriteLine(biggest);
        }
    }
}
