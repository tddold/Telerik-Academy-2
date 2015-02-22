using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
//percentage and in scientific notation.
//Format the output aligned right in 15 symbols.


class FormatNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine("Decimal number:");
        string formatDec = string.Format("{0,15}", number);
        Console.WriteLine(formatDec);       
        Console.WriteLine("Hex numbers:");
        string formatHex = String.Format("{0,15:X}", (int)number);
        Console.WriteLine(formatHex);
        Console.WriteLine("Percentages:");
        string formatPer = String.Format("{0,15:P1}", number / 100);
        Console.WriteLine(formatPer);
        Console.WriteLine("Scientific notation:");
        string formatSci = String.Format("{0,15:e}", number);
        Console.WriteLine(formatSci);
    }
}

