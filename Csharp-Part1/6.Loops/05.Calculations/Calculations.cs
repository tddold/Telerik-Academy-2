using System;
//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

class Calculations
{
    static void Main()
    {
        double fact_i = 1;
        double calc = 0;
        double sum = 0;
        double final_sum = 0;
        Console.WriteLine("Enter two integers n and x (S = 1 + 1!/x + 2!/x2 + … + n!/x^n)");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x=");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            fact_i = fact_i * i;
            calc = Math.Pow(x, i);
            sum = fact_i / calc;
            final_sum = sum + final_sum;
        }
        double result = final_sum + 1;
        Console.WriteLine("S={0:F5}", result);
    }
}
