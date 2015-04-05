//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


using System;
using System.Linq;


class Task06
{
    static void Main()
    {
        int[] array = { 2, 3, 4,42, 5, 7, 8, 9, 10,21 };
        int[] arrayTargetLambda = array.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();
        Console.WriteLine(String.Join((", "),arrayTargetLambda));
        var arrayTargetLINQ = from num in array
                                  where (num%3==0 && num%7==0)
                                  select num;
        Console.WriteLine(String.Join((", "), arrayTargetLINQ));
    }
}

