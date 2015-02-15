using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.
//
//Example:
//input 	output
//256 	652

class reverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        int reversedNumber = reverse(number);
        Console.WriteLine("The reversed number is:");
        Console.WriteLine(reversedNumber);
    }

    static int reverse(int forReversing)
    {
        char[] digits = forReversing.ToString().ToCharArray();
        string result="";
        int intResult = 0; ;
        for (int i = 0; i < digits.Length/2; i++)
        {           
            char temp=digits[i];
            digits[i] = digits[digits.Length - 1 - i];
            digits[digits.Length - 1 - i] = temp;
            //result = result + digits[i];            
        }
        return intResult = int.Parse(string.Join("",digits));        
    }
}

