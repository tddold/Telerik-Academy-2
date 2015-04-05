using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that
//are the same and the number of lines that are different.
//Assume the files have equal number of lines.


class CompareTextFiles
{
    static void Main()
    {
        String directory = @"..\..\";
        String[] linesA = File.ReadAllLines(Path.Combine(directory, "textfile1.txt"));
        String[] linesB = File.ReadAllLines(Path.Combine(directory, "textfile2.txt"));
        int countOfEqualLines = 0;
        int countOfDifferentLines = 0;
        for (int i = 0; i < linesA.Length; i++)
        {
            if (linesA[i] == linesB[i])
            {
                countOfEqualLines++;
            }
            else
            {
                countOfDifferentLines++;
            }
        }
        Console.WriteLine("Number of lines that are the same: {0}", countOfEqualLines);
        Console.WriteLine("Number of lines that are different: {0}", countOfDifferentLines);
    }
}

