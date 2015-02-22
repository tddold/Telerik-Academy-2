using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 20. Palindromes
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

class Palindromes
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex rgx = new Regex(@"[\w]+", RegexOptions.None);
        MatchCollection match = rgx.Matches(input);
        var listOfWords = new List<string>();
        foreach (var matched in match)
        {
            listOfWords.Add(matched.ToString());            
        }
        var listOfPalindromes = new List<string>();
        Console.WriteLine("Palindromes are:");
        foreach (var word in listOfWords)
        {
            bool palindrome = true;
            int length = word.Length;
            for (int i = 0; i < length/2; i++)
            {
                if (word[i] != word[length - i-1])
                {
                    palindrome = false;
                    break;
                }
                if (palindrome&&i==length/2-1)
                {                    
                    Console.WriteLine(word);
                }
            }
        }
        

    }
}

