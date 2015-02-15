﻿using System;

//Problem 12. Extract Bit from Integer
//
//    Write an expression that extracts from given integer n the value of given bit at index p.

class extractBitInteger
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the index p:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = number & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit); 
    }
}
