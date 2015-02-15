using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

class largestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the three integers:");
        int x1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int maxValue=Int32.MinValue; 
        maxValue = getMax(getMax(x1,x2),x3);
        Console.WriteLine("Max value is: {0}",maxValue);
    }
    static int getMax(int num1,int num2)
    {
        if (num1 >= num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }   
    }
}

