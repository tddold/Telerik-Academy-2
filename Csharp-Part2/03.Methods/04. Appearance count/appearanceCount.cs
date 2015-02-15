using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


class appearanceCount
{
    static void Main()
    {
        //*Zero tests
        //int[] arrayOfInts = { 2, 4, 5, 1, 2, 4, 5, 6 };        
        int[] arrayOfInts = { 2, 4, -5, -1, 2, 4, -5, 6 };
        
        //For manual entering you can uncomment this code:
        //Console.WriteLine("Enter the length of the array:");
        //int len=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the array:");
        //int[] arrayOfInts=new int[len];
        //for (int i=0;i<len;i++)
        //{
        //    arrayOfInts[i] = int.Parse(Console.ReadLine());
        //}

        Console.WriteLine("Enter the checked number:");
        int number = int.Parse(Console.ReadLine());

        checkNumber(arrayOfInts, number);
    }

    static void checkNumber(int[] array,int number)
    {
        int numberCountInArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                numberCountInArray++;
            }
        }
        Console.WriteLine("The number {0} appears in the given array {1} time(s).",number,numberCountInArray);
    }
}

