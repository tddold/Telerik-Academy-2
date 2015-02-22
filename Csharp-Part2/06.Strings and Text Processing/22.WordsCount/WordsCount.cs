using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 22. Words count
//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.


class WordsCount
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();                 
        string[] separators = new string[] {",", ".", "!", "\'", " ", "\'s"};
        string[] words = input.Split(separators ,
            StringSplitOptions.RemoveEmptyEntries);
        var listOfWords=new List<string>();
        for (int i = 0; i < words.Length; i++)
        {
            //1-ви вариант
            //int count = Regex.Matches(input, words[i]).Count;
            //Console.WriteLine("{0} - {1}",words[i],count);
            //2-ри вариант
            int count = 0;
            if (!listOfWords.Contains(words[i]))
            {
                listOfWords.Add(words[i]);
                for (int j = 0; j < words.Length; j++)
                {

                    if (words[i] == words[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine("{0} - {1}", words[i], count);
                count = 0;
            }
           
        }
      
    }
}

