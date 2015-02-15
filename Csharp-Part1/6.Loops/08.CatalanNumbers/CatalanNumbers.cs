using System;
//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).


class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter n:");
        double fact_n = 1;
        double fact_2n = 1;
        double fact_n_1 = 1;
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 2 * n; i++)
        {
            fact_2n = fact_2n * i;
            if (i <= n + 1)
            {
                fact_n_1 = fact_n_1 * i;
            }
            if (i <= n)
            {
                fact_n = fact_n * i;
            }
        }
        double result = (fact_2n) / (fact_n_1 * fact_n);
        Console.WriteLine("Catalan (n)={0:F5}", result);
    }
}
