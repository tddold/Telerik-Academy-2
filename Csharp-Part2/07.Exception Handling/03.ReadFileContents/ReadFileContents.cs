using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.


class ReadFileContents
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter file path and name:");
            //string path = Console.ReadLine();
            string path = @"D:\Telerik\Telerik-Academy\Csharp-Part2\07.Exception Handling\03.ReadFileContents\text.txt";
            string text = System.IO.File.ReadAllText(path);
            Console.WriteLine("The text in the file is:");
            Console.WriteLine(text);
        }
        catch (DirectoryNotFoundException ex) 
        {
            Console.WriteLine(ex.Message);           
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);      
        }
        catch (PathTooLongException ex)
        {         
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}

