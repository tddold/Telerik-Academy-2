using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9.* Binary floating-point
//Write a program that shows the internal binary representation of given 32-bit signed 
//floating-point number in IEEE 754 format (the C# type float).
//number 	sign 	exponent 	mantissa
//-27,25 	1 	10000011 	10110100000000000000000
class BinaryFloatingPoint
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        string numberToString = number.ToString();
        string[] arrayParts = numberToString.Split('.');
        string leftPartBinary = converterLeftPart(arrayParts[0]);
        string rightPartBinary = converterRightPart(arrayParts[1]);
        StringBuilder sb = new StringBuilder();
        sb.Append(leftPartBinary.Substring(1, leftPartBinary.Length - 1));
        sb.Append(rightPartBinary);
        int shift = leftPartBinary.Length - 1;
        int leftPartBias=127+shift;
        string leftPartBiasStr=leftPartBias.ToString();
        leftPartBinary = converterLeftPart(leftPartBiasStr);
        if (sb.Length<23)
        {
            for (int i = sb.Length; i < 23; i++)
            {
                sb.Append('0');
            }
        }
        StringBuilder allParts=new StringBuilder();
        if (number < 0)
        {
            allParts.Append('1');
        }
        else
        {
            allParts.Append('0');
        }
        allParts.Append(leftPartBinary);
       if (sb.Length > 23)
       {
           sb.Remove(23,sb.Length-23);
       }
        allParts.Append(sb);
        Console.WriteLine(allParts.ToString());
    }

    public static string converterLeftPart(string numberToString)
    {       
        int leftPartDecimal=int.Parse(numberToString);
        leftPartDecimal = Math.Abs(leftPartDecimal);
        string leftPartBinary="";
        while (leftPartDecimal > 0)
        {
            int digit = leftPartDecimal % 2;
            leftPartDecimal /= 2;
            leftPartBinary = digit+ leftPartBinary ;
        }        
        return leftPartBinary;
    }

    public static string converterRightPart(string numberToString)
    {
        double rightPartDecimal = double.Parse(numberToString);
        rightPartDecimal = rightPartDecimal / Math.Pow(10, numberToString.Length);
        string rightPartBinary = "";
        while (rightPartDecimal != 0&&rightPartBinary.Length<23)
        {
            rightPartDecimal = rightPartDecimal * 2;            
            if (rightPartDecimal < 1)
            {
                rightPartBinary = rightPartBinary + '0';
                continue;                
            }
            else if (rightPartDecimal == 1)
            {
                rightPartBinary = rightPartBinary + '1';
                rightPartDecimal=0;                
            }
            else if (rightPartDecimal > 1)
            {
                rightPartBinary = rightPartBinary + '1';
                rightPartDecimal = rightPartDecimal - 1;
            }            
        }
        //rightPartBinary = rightPartBinary + '0';
        return rightPartBinary;
    }
}

