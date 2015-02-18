using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

