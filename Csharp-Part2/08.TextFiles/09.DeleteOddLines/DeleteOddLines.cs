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
        string path = @"..\..\textfile.txt";
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            StreamWriter streamWriter = new StreamWriter(@"..\..\temp.txt");
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
        File.Delete(@"..\..\textfile.txt");
        File.Move(@"..\..\temp.txt",
            @"..\..\textfile.txt");
    }
}

