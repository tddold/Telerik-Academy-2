using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 13. Count words
//Write a program that reads a list of words from the file words.txt and finds how many times 
//each of the words is contained in another file test.txt.
//The result should be written in the file result.txt and the words
//should be sorted by the number of their occurrences in descending order.
//Handle all possible exceptions in your methods.


class CountWords
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\13.CountWords\words.txt");
            string words = string.Empty;
            List<string> list = new List<string>();
            using (reader)
            {
                words = reader.ReadToEnd();
                string resultForTheList = Regex.Replace(words, "[^a-zA-Z0-9_.\n]+", "", RegexOptions.Compiled);
                list = resultForTheList.Split(' ', ',', '\n').ToList();
            }
            StreamReader reader2 = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\13.CountWords\test.txt");
            string textForCheck = reader2.ReadToEnd();
            string[] source = textForCheck.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] countForEachWord = new int[list.Count];
            Dictionary<string, int> myDict = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++)
            {
                var matchQuery = from word in source
                                 where word.ToLowerInvariant() == list[i].ToLowerInvariant()
                                 select word;

                countForEachWord[i] = matchQuery.Count();
                myDict.Add(list[i], countForEachWord[i]);
            }
            var sortedDict = from entry in myDict orderby entry.Value descending select entry;


            StreamWriter writer = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\13.CountWords\result.txt");
            using (writer)
            {

                foreach (var sortedCell in sortedDict)
                {
                    writer.WriteLine("Key = {0}, Value = {1}",
                        sortedCell.Key, sortedCell.Value);
                    Console.WriteLine("Key = {0}, Value = {1}",
                        sortedCell.Key, sortedCell.Value);
                }
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

