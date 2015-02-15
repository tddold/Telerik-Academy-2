using System;
//Problem 3. Min, Max, Sum and Average of N Numbers
//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

class MinMaxSumMean
{
    static void Main()
    {
        int sum = 0;
        int min = 0;
        int max = 0;
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the sequence of n numbers");
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            sum += a;
            if (i == 0)
            {
                min = a;
            }
            if (min > a)
            {
                min = a;
            }
            if (i == 0)
            {
                max = a;
            }
            if (max < a)
            {
                max = a;
            }
        }
        double avg = (double)sum / n;
        Console.WriteLine("min={0}", min);
        Console.WriteLine("max={0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:F2}", avg);
    }
}
