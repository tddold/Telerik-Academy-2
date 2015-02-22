using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 21. Letters count
//Write a program that reads a string from the console and prints all different letters 
//in the string along with information how many times each letter is found.

class LettersCount
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        List<char> chars=new List<char>();
        List<int> counts = new List<int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (!chars.Contains(input[i])&&( (input[i] >= 'a' & input[i] <= 'z') ||( input[i] >= 'A' & input[i] <= 'Z')))
            {
                chars.Add(input[i]);
                counts.Add(0);
                for (int j = 0; j < input.Length;j++)
                {
                    if (chars[counts.Count-1] == input[j])
                    {
                        counts[counts.Count - 1] = counts[counts.Count - 1] + 1;
                    }
                }
                Console.WriteLine("{0} - {1}", chars[counts.Count - 1], counts[counts.Count - 1]);
            }
           
        }
    }
}

