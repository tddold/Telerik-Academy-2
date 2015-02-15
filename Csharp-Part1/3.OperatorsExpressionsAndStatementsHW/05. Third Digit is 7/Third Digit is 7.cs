using System;
using System.Linq;

//Problem 5. Third Digit is 7?
//
//    Write an expression that checks for given integer if its third digit from right-to-left is 7.

class thirdDigitIs7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        //char[] array = Convert.ToString(number, 10).ToArray();
        //int finalNumber=number-number%10;
        int finalNumber = number / 100;
        bool isSeven = false;
        if (finalNumber % 10 == 7)
        {
            isSeven = true;
            Console.WriteLine("Third digit is 7: {0}",isSeven);
        }
        else
        {
            isSeven = false;
            Console.WriteLine("Third digit is 7: {0}", isSeven);
        }              
    }
}
