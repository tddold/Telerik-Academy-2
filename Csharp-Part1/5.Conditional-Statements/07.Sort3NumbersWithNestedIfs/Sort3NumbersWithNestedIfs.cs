using System;
//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.
//Examples:
//a 	b 	c 	result
//5 	1 	2 	5 2 1
class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Sorted numbers:");
        if (a >= b && a >= c)
        {
            Console.Write("{0} ", a);
            if (b >= c)
            {
                Console.Write("{0} {1}", b, c);
            }
            else
            {
                Console.Write("{0} {1}", c, b);
            }
        }
        else
            if (b >= c)
            {
                Console.Write("{0} ", b);
                if (a >= c)
                {
                    Console.Write("{0} {1}", a, c);
                }
                else
                {
                    Console.Write("{0} {1}", c, a);
                }
            }
            else
            {
                Console.Write("{0} ", c);

                if (a >= b)
                {
                    Console.Write("{0} {1}", a, b);
                }
                else
                {
                    Console.Write("{0} {1}", b, a);
                }
            }
    }
}

