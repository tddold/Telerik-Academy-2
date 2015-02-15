using System;

//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

class CalculateNK
{
    static void Main()
    {
        double fact_n = 1;
        double fact_k = 1;
        Console.WriteLine("Enter two numbers n and k :");
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());
        int max = n > k ? n : k;
        for (int i = 1; i <= max; i++)
        {
            if (i <= n)
            {
                fact_n = fact_n * i;
            }
            if (i <= k)
            {
                fact_k = fact_k * i;
            }
        }
        double result = (fact_n) / (fact_k);
        Console.WriteLine("n! / k!= {0:F5}", result);
    }
}
