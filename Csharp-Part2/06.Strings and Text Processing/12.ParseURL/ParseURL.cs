using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12. Parse URL
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements.
//
//Example:
//URL 	Information
//http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
//[server] = telerikacademy.com
//[resource] = /Courses/Courses/Details/212
class ParseURL
{
    static void Main()
    {
        string text=Console.ReadLine();
        var url = new Uri(text);
         Console.WriteLine("[protocol]={0}",url.Scheme);
         Console.WriteLine("[server]={0}", url.Host);
         Console.WriteLine("[resource]={0}", url.AbsolutePath);
    }
}

