﻿using System;
//Problem 6. Maximal K sum.Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


class MaxKSum
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K:");
        int numberK = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers=new int[numberN];
        Console.WriteLine("Enter the array:");
        for (int i= 0; i < numberN; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrayOfNumbers, (a, b) => b.CompareTo(a)); 
        for (int count = 0; count < numberK; count++)
        {
            Console.Write("{0} ", arrayOfNumbers[count]);
        }
    }
}
