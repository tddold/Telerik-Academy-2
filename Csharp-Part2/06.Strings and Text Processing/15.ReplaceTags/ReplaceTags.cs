using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Problem 15. Replace tags
//Write a program that replaces in a HTML document given as string all the tags 
//<a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:
//input 	output
//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
//<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter your text:");
        string input = Console.ReadLine();
        string pattern = "<a href=\"";
        string replacement = "[URL=";
        string patternB = "\">";
        string replacementB = "]";
        string patternC = "</a>";
        string replacementC = "[/URL]";
        string result = Regex.Replace(input, pattern, replacement);
        result = Regex.Replace(result, patternB, replacementB);
        result = Regex.Replace(result, patternC, replacementC);
        Console.WriteLine("The cnahged text is:");
        Console.WriteLine(result);
    }
}


