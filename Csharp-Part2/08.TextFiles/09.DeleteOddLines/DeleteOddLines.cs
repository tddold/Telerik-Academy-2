using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

//There is a file textfile_before which I used for check after I have deleted the odd lines in the original file.
class DeleteOddLines
{
    static void Main()
    {
        string path = @"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\09.DeleteOddLines\textfile.txt";
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            StreamWriter streamWriter = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\09.DeleteOddLines\temp.txt");
            using (streamWriter)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();                
                while (line!= null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        streamWriter.WriteLine(line);                       
                    }
                    line = reader.ReadLine(); 
                   
                }
            }
        }
        Console.WriteLine("The odd lines are deleted from the input file : {0}",path);
        File.Delete(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\09.DeleteOddLines\textfile.txt");
        File.Move(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\09.DeleteOddLines\temp.txt",
            @"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\09.DeleteOddLines\textfile.txt");
    }
}

