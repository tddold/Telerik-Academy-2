using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 8. Replace whole word
//Modify the solution of the previous problem to replace only whole words (not strings).

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\08.ReplaceWholeWord\start.txt");
        Console.WriteLine("Enter word for change:");
        string word = Console.ReadLine();
        string output = string.Empty;
        using (reader)
        {
            StringBuilder sb = new StringBuilder();
            string allText = reader.ReadToEnd();
            Regex rgx = new Regex(@"\bstart\b");
            output = rgx.Replace(allText, "finish");
        }
        StreamWriter streamWriter = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\08.ReplaceWholeWord\end.txt");
        using (streamWriter)
        {
            streamWriter.Write(output);
        }
        Console.WriteLine(output);
    }
}


