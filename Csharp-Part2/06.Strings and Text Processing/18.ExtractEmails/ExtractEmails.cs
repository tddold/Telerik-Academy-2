using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.


class ExtractEmails
{
    static void Main()
    {
        string input = Console.ReadLine();
        Regex rgx = new Regex(@"\b[a-z0-9]+\@[a-z0-9]+\.[a-z]{2,3}\b", RegexOptions.None);
        MatchCollection emails = rgx.Matches(input);
        foreach (var match in emails)
        {
            Console.WriteLine(match);
        }
    }
}

