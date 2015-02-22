using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 11. Prefix "test"
//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

//There is a file textfile_before which I used for check after I have deleted the the words starting with test in the original file.
class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\11.PrefixTest\textfile.txt");
        string alltext = string.Empty; 
        using (reader)
        {
            alltext = reader.ReadToEnd();
        }
        Regex rgx = new Regex(@"\stest(?<=).*?(?=\s)");
        StringBuilder sb=new StringBuilder();
        string result = rgx.Replace(alltext, "");
        for (int i = 0; i < result.Length; i++)
        {
            if ((result[i]>='a'&&result[i]<='z')||(result[i]>='A'&&result[i]<='Z')||
                (result[i]>='0'&&result[i]<='9')||result[i]=='_'||result[i]=='.'||result[i]==','
                || result[i] == ' ')
            {
                sb.Append(result[i]);
            }
            if (i > 0&& result[i-1]=='\r'&&result[i]=='\n')
            {
                sb.Append("\r\n");
            }
        }
        result = sb.ToString();
            Console.Write(result);
        StreamWriter writer= new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\11.PrefixTest\temp.txt");
        using (writer)
        {
            writer.Write(result);
        }
        File.Delete(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\11.PrefixTest\textfile.txt");
        File.Move(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\11.PrefixTest\temp.txt",
            @"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\11.PrefixTest\textfile.txt");
    }
}

