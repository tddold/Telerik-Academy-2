using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7. One system to any other
//Write a program to convert from any numeral system of given base s to any other
//numeral system of base d (2 ≤ s, d ≤ 16).

class  oneSystemToAnyOther
{
    static void Main()
    {
        Console.WriteLine("Enter numeral system S");
        int typeS = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter numeral system D");
        int typeD = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number from type S numeral system:");
        string numberTypeS = Console.ReadLine();
             
        char[] charTypeS = numberTypeS.ToCharArray();
        int convertedFromTypeSToDec= TypeSToDec(typeS, charTypeS);
        //Console.WriteLine(convertedFromTypeSToDec);
        string convertedNumber = decToTypeD(typeD, convertedFromTypeSToDec);
        Console.WriteLine(convertedNumber);
    }

    public static int TypeSToDec(int typeS,char[] systemToBeConverted)
    {
        int decimalNumber=0;
        for (int i = 0;i <= systemToBeConverted.Length - 1;  i++)
        {
            if (systemToBeConverted[i]>='A'&&systemToBeConverted[i]<='F')
            {
                decimalNumber=decimalNumber+((int)Math.Pow(typeS,systemToBeConverted.Length -i-1))*(systemToBeConverted[i]-'@'+9);
            }
            else
            {
                decimalNumber=decimalNumber+((int)Math.Pow(typeS,systemToBeConverted.Length -i-1))*(systemToBeConverted[i]-'0');
            }
        }
        return decimalNumber;
    }
    public static string decToTypeD(int typeD, int decimalNumber)
    {
        string finalNumber="";
        while (decimalNumber>0)
        {
            int digit = decimalNumber % typeD;
            decimalNumber /= typeD;
            char digitConverted=digit>9?(char)(digit+55):(char)(digit+'0');
            finalNumber = digitConverted+finalNumber;
        }
        return finalNumber;
    }
}

