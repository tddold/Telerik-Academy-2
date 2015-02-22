using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 10. Extract text from XML
//Write a program that extracts from given XML file all the text without the tags.
//Example:
////<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\10.ExtractTextFromXML\letter.xml");
        string alltext=string.Empty;
        using (reader)
        {
            alltext = reader.ReadToEnd();
        }
        //Regex rgx = new Regex(@"\<\w+\>|\<\/\w+\>|\<a.*");
        Regex rgx = new Regex(@"\<(?<=<).*?(?=>)\>");

        string result=rgx.Replace(alltext,"");
        Console.WriteLine(result);
        StreamWriter writer = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\10.ExtractTextFromXML\letter_amended.xml");
        using (writer)
        {
            writer.Write(result);
        }
    }
}

