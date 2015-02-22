using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\01.OddLines\textfile.txt");
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);                   
                }
                line = reader.ReadLine();
            }
        }
    }
}

