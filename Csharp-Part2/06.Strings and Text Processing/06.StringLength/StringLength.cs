using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6. String length
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.


class StringLength
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Enter string:");
        int i, count = 0;

        while ((i = Console.Read()) != 13) 
        {
            if (++count > 20) break;
            sb.Append((char)i);            
        }
        if (sb.Length < 20)
        {
            for (int j = sb.Length; j < 20; j++)
            {
                sb.Append('*');
            }
        }
        Console.WriteLine("The result string is:");
        Console.WriteLine(sb.ToString());
    }
}

