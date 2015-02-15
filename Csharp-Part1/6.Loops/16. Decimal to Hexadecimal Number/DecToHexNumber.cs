﻿using System;

//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.


class decToHexNumber
{
    static void Main()
    {
        Console.WriteLine("Enter decimal number:");
        ulong number = ulong.Parse(Console.ReadLine());
        bool start = false;
        char mul = ' ';
        Console.WriteLine("The hedecimal representation of the numebr is:");
        for (int i = 15; i >= 0; i--)
        {
            ulong downBoundary = (ulong)Math.Pow(16, i);

            if (downBoundary <= number)
            {
                ulong x = number / downBoundary;
                number = number - x * downBoundary;
                switch (x)
                {
                    case 0: mul = '0'; break;
                    case 1: mul = '1'; break;
                    case 2: mul = '2'; break;
                    case 3: mul = '3'; break;
                    case 4: mul = '4'; break;
                    case 5: mul = '5'; break;
                    case 6: mul = '6'; break;
                    case 7: mul = '7'; break;
                    case 8: mul = '8'; break;
                    case 9: mul = '9'; break;
                    case 10: mul = 'A'; break;
                    case 11: mul = 'B'; break;
                    case 12: mul = 'C'; break;
                    case 13: mul = 'D'; break;
                    case 14: mul = 'E'; break;
                    case 15: mul = 'F'; break;
                }
                start = true;
                Console.Write((char)mul);
            }
            else if (start)
            {
                Console.Write("0");
            }
        }
        Console.WriteLine();
    }
}

