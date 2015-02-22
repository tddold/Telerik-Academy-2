using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8. Extract sentences
//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

class ExtractSentences
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        Console.WriteLine("Enter word for checking:");
        string wordForCheck = Console.ReadLine();
        StringBuilder sb = new StringBuilder();        
        sb.Append(wordForCheck);       
        string[] arrayOfSentences = input.Split('.');
        bool found=false;
        for (int i = 0; i < arrayOfSentences.Length; i++)
        {
            found = arrayOfSentences[i].Substring(0, arrayOfSentences[i].Length).Contains((sb.ToString() + " "));
           if (found==true)
           {
               Console.Write(arrayOfSentences[i]+".");
               found = false;
           }
        }
        Console.WriteLine();
    }
}

