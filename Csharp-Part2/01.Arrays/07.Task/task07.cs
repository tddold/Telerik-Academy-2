using System;
using System.Collections.Generic;
//Problem 7. Selection sort.Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. 
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.


class selectionsort
{
    static void Main()
    {
        int[] arr = { 2, 341, -22, 11, 44 };
        //int[] arr = { -6, -1, 4, 3, 0, 3, 6, 14, 15 };
        int minValue = arr[0];
        int count = 0;
        int indexOfMin = 0;       
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                minValue = arr[i];
                indexOfMin = i;
            }
            if (i == arr.Length - 1)
            {
                int temp = arr[count];
                arr[count] = minValue;                
                count++;                
                arr[indexOfMin] = temp;
                i = count;
                minValue = arr[count];
                indexOfMin = count;
            }
        }
        Console.WriteLine(string.Join((", "),arr));
    }
}


