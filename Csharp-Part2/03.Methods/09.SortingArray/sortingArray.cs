using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.


class sortingArray
{
    static void Main()
    {
        //*Zero tests
        //int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };
        int[] arrayOfInts = { 3, 4, 5, 7, 12, 14, 15, 15 };        
        //int[] arrayOfInts = { 2, 1, -5, -1, 2, 4, -5, 6 };

        //For manual entering you can uncomment this code:
        //Console.WriteLine("Enter the length of the array:");
        //int len=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the array:");
        //int[] arrayOfInts=new int[len];
        //for (int i=0;i<len;i++)
        //{
        //    arrayOfInts[i] = int.Parse(Console.ReadLine());
        //}      
        Console.WriteLine("Enter start index:");
        int startIndex = int.Parse(Console.ReadLine());
        int maxNumber = checkForBiggestNumber(arrayOfInts, startIndex);
        Console.WriteLine("The maximal number in the portion of the array");
        Console.WriteLine("started from {0} is {1}.", startIndex, maxNumber);
    }

    static int checkForBiggestNumber(int[] arrayOfInts, int startIndex)
    {
        int maxValue=Int32.MinValue;
        for (int i = startIndex; i < arrayOfInts.Length;i++ )
        {
            if (arrayOfInts[i] > maxValue)
            {
                maxValue = arrayOfInts[i];
            }
        }
        return maxValue;
    }

}
