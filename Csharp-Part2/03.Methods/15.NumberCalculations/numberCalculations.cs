using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 15.* Number calculations
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).


class integerCalclulations
{
    static void Main()
    {
        Console.WriteLine("Sequence {1,2,3,4,5,6,7,8,9,10}");
        Console.WriteLine("The minimal number in the sequence is {0}", min(1.2, 2.3, 3.3, 4.4, 5.2, 6.3, 7.2, 8.2, 9, -110.2));
        Console.WriteLine("The maximal number in the sequence is {0}", max(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        Console.WriteLine("The average in the sequence is {0}", average(1.2, 2.3, 3.9, 4.4, 5.5, 6.6));
        Console.WriteLine("The sum of the numbers in the sequence is {0}", sum(1.2, 2.4, 3.3));
        Console.WriteLine("The product of the numbers in the sequence is {0}", product(1.2, 2.2, 3.3));
    }

    static T min<T>(params T[] numbers)
    {
        dynamic min = Int32.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static T max<T>(params T[] numbers)
    {
        dynamic max = Int32.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static T  average<T>(params T[] numbers)
    {
        dynamic sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        dynamic average = (double)sum / numbers.Length;
        return average;
    }
    static T sum<T>(params T[] numbers)
    {
        dynamic sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static T product<T>(params T[] numbers)
    {
        dynamic product = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}

