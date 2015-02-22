using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7. Replace sub-string
//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

class ReplaceSubString
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\07.ReplaceSubString\start.txt");
        using (reader)
        {
            StringBuilder sb = new StringBuilder();
            string allText = reader.ReadToEnd();
            for (int i = 0; i < allText.Length; i++)
            {
                if (i < allText.Length - 4)
                {
                    string sub = allText.Substring(i, 5);
                    if (sub == "start")
                    {
                        sb.Append("finish");
                        i = i + 4;
                    }
                    else
                    {
                        sb.Append(allText[i]);
                    }
                }
                else
                {
                    sb.Append(allText[i]);
                }
                
            }
            StreamWriter streamWriter = new StreamWriter(@"D:\Telerik\Telerik-Academy\Csharp-Part2\08.TextFiles\07.ReplaceSubString\end.txt");
            using (streamWriter)
            {
                streamWriter.Write(sb.ToString());               
            }
            Console.WriteLine(sb.ToString());
        }
        
    }
}

