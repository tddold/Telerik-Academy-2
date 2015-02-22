using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\03.LineNumbers\textfile.txt");
        StreamWriter writer = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\03.LineNumbers\newtext.txt");
        using (reader)
        {
            using (writer)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);


                    writer.WriteLine("Line {0}: {1}", lineNumber, line);

                    line = reader.ReadLine();
                }
            }
        }
    }
}

