using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].

class nFactorial
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        BigInteger factoriel= factorielCalc(number);
        Console.WriteLine("!n facktoriel from {0} is {1}",number,factoriel);
    }

    public static BigInteger factorielCalc(int number)
    {

        BigInteger product = 1;        
        for (int i = 2; i <= number; i++)
        {
            product *= i;
        }
        return product;
    }    
}
