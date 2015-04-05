using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Problem 2. Enter numbers
//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//        If an invalid number or non-number text is entered, the method should throw an exception.
//    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


class EnterNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the start and the end of the range:");
        int start=int.Parse(Console.ReadLine());
        int end=int.Parse(Console.ReadLine());
        int count = 0;
        while (count<10)
        {
            int number = int.Parse(Console.ReadLine());
            bool isValid = ReadNumber(start, end,number);
            if (isValid == true)
            {
                count++;
            }
        }
    }
    static  bool ReadNumber(int start, int end,int number)
    {
        bool isValid = true;
        try
        {               
            Console.WriteLine("Enter number in the range {0} - {1}", start, end);
           
            if (number >= start && number <= end)
            {
                Console.WriteLine("{0} is in the range", number);                
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number is out of range");
                
            }
        }
        catch(Exception)
        {
            Console.WriteLine("Invalid number");
            isValid = false;
        }       
        return isValid;
       
    }
}





