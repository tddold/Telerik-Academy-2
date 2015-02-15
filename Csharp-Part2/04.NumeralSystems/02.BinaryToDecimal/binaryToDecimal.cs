using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class binaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string binNumber =Console.ReadLine();
        char[] binArray = binNumber.ToString().ToCharArray();
        Array.Reverse(binArray);
        double decNumber = 0;
        for (int i = 0; i < binArray.Length;i++)
        {
            decNumber =(binArray[i]-'0')*Math.Pow(2, i) + decNumber;
        }             
        Console.WriteLine("The decimal representation of the binary number is:");
        Console.WriteLine("{0}", decNumber);
    }
}

