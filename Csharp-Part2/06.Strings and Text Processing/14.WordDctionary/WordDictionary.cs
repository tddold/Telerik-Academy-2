﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14. Word dictionary
//
//    A dictionary is stored as a sequence of text lines containing words and their explanations.
//    Write a program that enters a word and translates it by using the dictionary.
//
//Sample dictionary:
//input 	output
//.NET 	platform for applications from Microsoft
//CLR 	managed execution environment for .NET
//namespace 	hierarchical organization of classes

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        //For additional check
        //ENTER the length of the divitionary
        // int length=int.Parse(Console.ReadLine());
        // for (int i=0;i<length;i++)
        // {
        //     Console.Write("Enter string index: ");
        //     string index=Console.ReadLine();
        //     Console.Write("Enter string meaning: ");
        //     string meaning = Console.ReadLine();
        //     dictionary.Add(index,meaning);            
        // }
        bool isChecking=true;
        while (isChecking)
        {
            Console.WriteLine("Enter string index for check from the dictionary: ");
            Console.WriteLine("(if you want to end the cycle type END):");
            string index = Console.ReadLine();
            if (dictionary.ContainsKey(index))
            {
                Console.WriteLine(dictionary[index]);
                Console.WriteLine();
            }
            else if (index=="END")
            {
                isChecking = false;
            }
        }
    }
}

