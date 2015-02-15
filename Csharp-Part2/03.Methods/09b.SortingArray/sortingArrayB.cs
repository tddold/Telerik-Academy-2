using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

class sortingArrayB
{
    static void Main()
    {
        //*Zero tests
        int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };
        //int[] arrayOfInts = { 3, 4, 5, 7, 12, 14, 15, 15 };
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
        int[] arrayOfIntsClone = arrayOfInts.Clone() as int[];
        int[] sortedarrayDesc = sortDescending(arrayOfInts);
        int[] sortedarrayAsc = sortAscending(arrayOfIntsClone);
        Console.WriteLine("Sorted array:");
        Console.WriteLine("{0}",string.Join(", ",sortedarrayDesc));
        Console.WriteLine("{0}", string.Join(", ", sortedarrayAsc));
    }

    static int[] sortDescending(int[] arrayOfIntsDesc)
    {
        int start = 0;
        int maxValueIndex = 0;
        int maxValue = Int32.MinValue;        
        for (int i = 0; i < arrayOfIntsDesc.Length; i++)
        {
            for (int j =start; j < arrayOfIntsDesc.Length; j++)
            {
                if (arrayOfIntsDesc[j] > maxValue)
                {
                    maxValue = arrayOfIntsDesc[j];
                    maxValueIndex = j;
                }
                if (j == arrayOfIntsDesc.Length - 1)
                {
                    int temp = arrayOfIntsDesc[i];
                    arrayOfIntsDesc[i] = maxValue;
                    arrayOfIntsDesc[maxValueIndex] = temp;
                    maxValue = Int32.MinValue;
                    start++;
                }
            }
        }
        return arrayOfIntsDesc;
    }
    static int[] sortAscending(int[] arrayOfIntsAsc)
    {
        int start = 0;
        int minValueIndex = 0;
        int minValue = Int32.MaxValue;
        for (int i = 0; i < arrayOfIntsAsc.Length; i++)
        {
            for (int j = start; j < arrayOfIntsAsc.Length; j++)
            {
                if (arrayOfIntsAsc[j] < minValue)
                {
                    minValue = arrayOfIntsAsc[j];
                    minValueIndex = j;
                }
                if (j == arrayOfIntsAsc.Length - 1)
                {
                    int temp = arrayOfIntsAsc[i];
                    arrayOfIntsAsc[i] = minValue;
                    arrayOfIntsAsc[minValueIndex] = temp;
                    minValue = Int32.MaxValue;
                    start++;
                }
            }
        }
        return arrayOfIntsAsc;
    }
}
