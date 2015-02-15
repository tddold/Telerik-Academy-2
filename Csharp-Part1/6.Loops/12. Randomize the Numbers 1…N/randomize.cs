﻿using System;
//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.


class randomize
{
    static void Main()
    {
        Console.WriteLine("Enter N (sequence 1..N)");
        int number = int.Parse(Console.ReadLine());
        int[] newNumbers = new int[number];
        bool isEqual = true;

        Random rnd = new Random();
        int random = 0;
        Console.WriteLine("Randomized sequence from 1 to N");
        for (int i = 0; i < number; i++)
        {
            while (isEqual == true)
            {
                isEqual = false;
                random = rnd.Next(1, number + 1);
                for (int j = 0; j <= i; j++)
                {

                    if (random == newNumbers[j])
                    {
                        isEqual = true;
                    }
                }
                if (isEqual == false)
                {
                    newNumbers[i] = random;
                }
            }
            Console.Write("{0} ", newNumbers[i]);
            isEqual = true;
        }
    }
}

