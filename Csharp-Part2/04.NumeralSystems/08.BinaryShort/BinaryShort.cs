using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8. Binary short
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Enter type short number:");
        short number = short.Parse(Console.ReadLine());
        int posNumber = Math.Abs(number);
        string binary = "";
        while (posNumber > 0)
        {
            int digit = posNumber % 2;
            posNumber = posNumber / 2;
            binary = digit + binary;
        }
        StringBuilder sbBinary = new StringBuilder();
        for (int i = binary.Length; i < 15; i++)
        {
            binary = '0' + binary;
        }
        char signChar= number < 0 ? '1' : '0';
        binary = signChar + binary;

        sbBinary = convertNegDig(binary, number, sbBinary);

        if (number < 0)
        {
            StringBuilder sbBinaryConverted = convertNegative(sbBinary, number);
        }
       
            binary = sbBinary.ToString(); 
       
        Console.WriteLine(binary);
       
    }

    public static StringBuilder convertNegDig(string binary, int number, StringBuilder sbBin)
    {
        for (int i = 0; i < binary.Length; i++)
        {
            if (number < 0)
            {
                if (binary[i] == '0' && i > 0)
                {
                    sbBin.Append('1');
                }
                else if (binary[i] == '1' && i > 0)
                {
                    sbBin.Append('0');
                }
                else if (i == 0)
                {
                    sbBin.Append(binary[i]);
                }
            }
            else
            {
                sbBin.Append(binary[i]);
            }
        }
        return sbBin;
    }

    public static StringBuilder convertNegative(StringBuilder sbBinary,int number)
    {
        bool isOne = true;
        int count = sbBinary.Length - 1;
        while (isOne && number < -1)
        {
            if (sbBinary[count] == '1')
            {
                sbBinary.Replace('1', '0', count, 1);
            }
            count--;
            if (sbBinary[count] == '0')
            {
                sbBinary.Replace('0', '1', count, 1);
                isOne = false;
            }
        }
        if (number == -1)
        {
            sbBinary.Replace('0', '1', sbBinary.Length-1, 1);
        }
        return sbBinary;
    }
}

