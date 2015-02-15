using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Decimal to binary
//Write a program to convert decimal numbers to their binary representation.

class numeralSystems
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        int decNumber = int.Parse(Console.ReadLine());
        int decResult=decNumber;
        int bin=0;
        string binaryResult = "";
        while (decResult>0)
        {
            bin =decResult>=2?decResult % 2:1;
            binaryResult += bin;
            decResult = decResult / 2;
        }
        char[] binaryArray = binaryResult.ToCharArray();
        Array.Reverse(binaryArray);
        string finalBinaryResult = new string(binaryArray);
        Console.WriteLine("The binary representation of the decimal number is:");
        Console.WriteLine("{0}",finalBinaryResult);
    }
}

