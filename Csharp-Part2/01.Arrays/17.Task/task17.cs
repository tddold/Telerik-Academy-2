using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 17.* Subset K with sum S.Write a program that reads three integer numbers N, K and S and
//an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

class subsetKWithSumS
{
    static void Main()
    {
        Console.WriteLine("Enter number S:");
        int numberS = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter N - the length of the array:");
        int len = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K - the number of elements in the array that should be equal to S:");
        int kELements = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[len];
        List<int> listOfResults = new List<int>();
        int sum = 0;
        bool isFirst = true;
        int countOfResults = 0;
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < len; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        int bitCount=0;
        double binaryTop = Math.Pow(2, len) - 1;
        for (int i = 0; i <= binaryTop; i++)
        {
            for (int j = 0; j < len; j++)
            {
                int mask = 1 << j;
                int maskAndI = mask & i;
                int bit = maskAndI >> j;
                if (bit == 1)
                {
                    listOfResults.Add(arrayOfNumbers[j]);
                    sum = arrayOfNumbers[j] + sum;
                    bitCount++;
                }
            }
            if (sum == numberS&&bitCount==kELements)
            {
                if (isFirst)
                {
                    Console.WriteLine("Yes");
                    isFirst = false;
                }
                for (int z = 0; z < listOfResults.Count; z++)
                {
                    Console.Write("{0} ", listOfResults[z]);
                    countOfResults++;
                }
                if (countOfResults > 0)
                {
                    Console.WriteLine();
                }
            }
            listOfResults.Clear();
            sum = 0;
            bitCount = 0;
        }
        if (countOfResults == 0)
        {
            Console.WriteLine("No");
        }
    }
}