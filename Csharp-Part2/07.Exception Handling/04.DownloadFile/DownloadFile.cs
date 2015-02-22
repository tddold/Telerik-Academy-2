using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.


class DownloadFile
{
    static void Main()
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
                Console.WriteLine("Enter the path of the file and the name of the file that will be downloaded in \" ");
                string path = Console.ReadLine();
                Console.Write("Enter the file name with extension:");
                string fileName = Console.ReadLine();
                Console.WriteLine("Example");
                Client.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "ninja.png");
                Client.DownloadFile(path, fileName);
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exception caught!\n{0} - {1}", ex.GetType().Name, ex.Message); 
        }
        


    }
}

