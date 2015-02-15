using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

class integerCalclulations
{
    static void Main()
    {
        Console.WriteLine("Sequence {1,2,3,4,5,6,7,8,9,10}");
        Console.WriteLine("The minimal number in the sequence is {0}", min(1,2,3,4,5,6,7,8,9,10));
        Console.WriteLine("The maximal number in the sequence is {0}", max(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The average in the sequence is {0}", average(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The sum of the numbers in the sequence is {0}", sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The product of the numbers in the sequence is {0}", product(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
    }

    static int min(params int[] numbers)
    {
        int min = Int32.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static int max(params int[] numbers)
    {
        int max = Int32.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static double average(params int[] numbers)
    {
        int sum = 0;
       
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        double average = (double)sum / numbers.Length;
        return average;
    }
    static int sum(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }        
        return sum;
    }
    static int product(params int[] numbers)
    {
        int product=1;

        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}

