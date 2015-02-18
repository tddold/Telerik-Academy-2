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
        Console.WriteLine("{0,15}",number);
        Console.WriteLine("Hex numbers:");
        Console.WriteLine("{0,15:X}", (int)number);
        Console.WriteLine("Percentages:");     
        Console.WriteLine("{0,15:P1}", number/100);
        Console.WriteLine("Scientific notation:");
        Console.WriteLine("{0,15:e}", number);
    }
}

