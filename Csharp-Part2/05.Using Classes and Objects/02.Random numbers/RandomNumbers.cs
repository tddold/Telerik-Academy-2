using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2. Random numbers
//Write a program that generates and prints to the console 10 random values in the range [100, 200].



class RandomNumbers
{
    static void Main()
    {
        Random randomGen = new Random();
        for (int i = 0; i < 20; i++)
        {
           int ramdomNumber=randomGen.Next(100,201);
           Console.WriteLine(ramdomNumber);
        }
    }
}

