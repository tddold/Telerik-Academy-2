using System;
//Problem 9. Matrix of Numbers
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and 
//prints a matrix like in the examples below. Use two nested loops.


class MatrixofNumbers
{
    static void Main()
    {
        int result = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result = i + j;
                Console.Write(result);
                if (j == n - 1)
                {
                    Console.Write("\n");
                }
            }
        }

    }
}
