﻿using System;
//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character 	
//Valid card sign?
//5 	yes
class CheckForAPlayCard
{
    static void Main()
    {
        Console.WriteLine("Eneter your card:");
        string card = Console.ReadLine();
        switch (card)
        {
            case "2": Console.WriteLine("yes"); break;
            case "3": Console.WriteLine("yes"); break;
            case "4": Console.WriteLine("yes"); break;
            case "5": Console.WriteLine("yes"); break;
            case "6": Console.WriteLine("yes"); break;
            case "7": Console.WriteLine("yes"); break;
            case "8": Console.WriteLine("yes"); break;
            case "9": Console.WriteLine("yes"); break;
            case "10": Console.WriteLine("yes"); break;
            case "J": Console.WriteLine("yes"); break;
            case "Q": Console.WriteLine("yes"); break;
            case "K": Console.WriteLine("yes"); break;
            case "A": Console.WriteLine("yes"); break;
            default: Console.WriteLine("No"); break;
        }
    }
}

