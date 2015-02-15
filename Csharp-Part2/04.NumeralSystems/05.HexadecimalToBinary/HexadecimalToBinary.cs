using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5. Hexadecimal to binary
//Write a program to convert hexadecimal numbers to binary numbers (directly).


class hexadecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        string hexNumber = Console.ReadLine();
        char[] arrayOfChars = hexNumber.ToCharArray();       
        string bin = "";
        string binaryNumber="";
        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (arrayOfChars[i])
            {
                case '0': bin = "0000"; break;
                case '1': bin = "0001"; break;
                case '2': bin = "0010"; break;
                case '3': bin = "0011"; break;
                case '4': bin = "0100"; break;
                case '5': bin = "0101"; break;
                case '6': bin = "0110"; break;
                case '7': bin = "0111"; break;
                case '8': bin = "1000"; break;
                case '9': bin = "1001"; break;
                case 'A': bin = "1010"; break;
                case 'B': bin = "1011"; break;
                case 'C': bin = "1100"; break;
                case 'D': bin = "1101"; break;
                case 'E': bin = "1110"; break;
                case 'F': bin = "1111"; break;
            }
            binaryNumber = binaryNumber+bin;           
        }
        Console.WriteLine("Binary representation of the hexadecimal number is:");
        Console.WriteLine(binaryNumber);
    }
}

