using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 25. Extract text from HTML
//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//Example input:
////<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skilful .NET software engineers.</p></body>
//</html>
//Output:
//Title: News
//Text: Telerik Academy aims to provide free real-world practical training for
//young people who want to turn into skilful .NET software engineers.

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        //string input = Console.ReadLine();
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">
Telerik Academy</a> aims to provide free real-world practical training 
for young people who want to turn into skilful .NET software engineers.</p></body></html>";
        string interim = Regex.Replace(input, "<title>", "Title:");
        string interim2 = Regex.Replace(interim, "<body>", "\nText:");
        Regex rgx = new Regex(@"\<(?<=<).*?(?=>)\>");
        //Regex rgx = new Regex(@"\<\w+\>|\<\/\w+\>|\<a.*");
        string result = rgx.Replace(interim2, "");       
        Console.WriteLine(result);
    }
}

