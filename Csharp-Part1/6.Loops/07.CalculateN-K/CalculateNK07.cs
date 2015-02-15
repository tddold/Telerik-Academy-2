using System;

//Problem 7. Calculate N! / (K! * (N-K)!)
//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: 
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

class CalculateNK07
{
    static void Main()
    {
        double fact_n = 1;
        double fact_k = 1;
        double fact_diff = 1;
        Console.WriteLine("Enter n and k (N! / (K! * (N-K)!))");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        double diff = n - k;
        for (int i = 1; i <= n; i++)
        {
            fact_n = fact_n * i;
            if (i <= k)
            {
                fact_k = fact_k * i;

            }
            if (i <= diff)
            {
                fact_diff = fact_diff * i;
            }
        }
        double result = (fact_n) / (fact_k * fact_diff);
        Console.WriteLine("{0:F5}", result);
    }
}

