using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 9. Forbidden words
//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        //*For thoroug check ucnomment bellow and comment the two rows above
        //*For thoroug check ucnomment bellow and comment the two rows above
        //*For thoroug check ucnomment bellow and comment the two rows above
        //string input = Console.ReadLine();
        //string[] arrayOfWords = input.Split(' ');
        Console.WriteLine("Enter forbidden words on the next row");
        //string[] stringSeparators = new string[] {", "};
        //string rowWords=Console.ReadLine();
        //string[] forbiddenWords = rowWords.Split(stringSeparators, StringSplitOptions.None);
        
        
        StringBuilder sb=new StringBuilder();
        int pos=-1;
        int start = 0;
        string result = "";
        for (int i=0;i<forbiddenWords.Length;i++)
        {
        do            
        {
            pos=input.IndexOf(forbiddenWords[i]);
            if (pos != -1)
            {
                string sub = input.Substring(start, pos);
                sb.Append(sub);
                sb.Append('*', forbiddenWords[i].Length);
                string rest = input.Substring(pos + forbiddenWords[i].Length, input.Length - sb.Length);
                sb.Append(rest);
                input = sb.ToString();
                start =0;
                result = sb.ToString();
                sb.Clear();
            }            
        }        
        while (pos!=-1);
        }
        Console.WriteLine("The revised text after replacing the forbidden words with '*'");
        Console.WriteLine(result);
    }
}

