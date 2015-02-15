using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5. Parse tags
//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = Console.ReadLine();
        string searchForThisOpen = "<upcase>";
        string searchForThisClose = "</upcase>";
        bool unfinished=true;
        StringBuilder sb = new StringBuilder();
        int firstCharClose=-1;
        int firstCharOpen=-1;
        while (unfinished)
        {
            firstCharOpen = input.IndexOf(searchForThisOpen);
            firstCharClose = input.IndexOf(searchForThisClose);
            if (firstCharOpen > -1 && firstCharClose > -1)
            {
                sb.Append(input[0],)
            }
        }
        

    }
}

