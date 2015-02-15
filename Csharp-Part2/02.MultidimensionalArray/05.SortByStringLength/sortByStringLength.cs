using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5. Sort by string length
//You are given an array of strings. Write a method that sorts the array 
//by the length of its elements (the number of characters composing them).


class SortStringLength
{
    static void Main()
    {
        int len = 4;
        string[] arrayOfStrings = { "aaaaa", "bbbbbbbb", "ccc","t" };
        //Console.WriteLine("Enter the length of the array:");
        //int len = int.Parse(Console.ReadLine());
        //string[] arrayOfStrings = new string[len];
        //for (int i=0;i<len;i++)
        //{
        //    arrayOfStrings[i]=Console.ReadLine();       
        //}
        int overallMinLength=0;
        int minLengthIndex = 0;
        int currentMinLength = arrayOfStrings[0].Length;
        int start = 0;
        for (int i = 0; i < len; i++)
        {
            currentMinLength = arrayOfStrings[i].Length;
            overallMinLength = arrayOfStrings[i].Length;
            string temp="";
            for (int j = start; j < len; j++)
            {
                if (overallMinLength >arrayOfStrings[j].Length)
                {
                    minLengthIndex = j;
                    overallMinLength = arrayOfStrings[j].Length;
                }               
            }
            temp = arrayOfStrings[i];
            arrayOfStrings[i] = arrayOfStrings[minLengthIndex];
            arrayOfStrings[minLengthIndex] =temp;
            start++;
        }
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine(arrayOfStrings[i]);
        }


    }
}

