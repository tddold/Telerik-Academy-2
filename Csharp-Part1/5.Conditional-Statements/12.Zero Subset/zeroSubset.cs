using System;
using System.Linq;
using System.Collections.Generic;
//Problem 12.* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:
//numbers 	result
//3 -2 1 1 8 	-2 + 1 + 1 = 0
class zeroSubset
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numebrs:");
        string input = Console.ReadLine();
        int[] arrayOfInts = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        List<int> listOfResults=new List<int>();
        int sum = 0;
        int countOfResults = 0;
        for (int i = 1; i <= 31; i++)
        {
            for (int j=0;j<5;j++)
            {
                int mask =  1<<j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;
                if (bit == 1)
                {
                    listOfResults.Add(arrayOfInts[j]);
                    sum = arrayOfInts[j] + sum;                    
                }
                if (sum == 0 && j == 4)
                {
                    for (int z = 0; z < listOfResults.Count; z++)
                    {
                        Console.Write("{0} ", listOfResults[z]);
                        countOfResults++;
                    }
                    Console.WriteLine();
                }                
            }
            listOfResults.Clear();
            sum = 0;
        }
        if (countOfResults == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

