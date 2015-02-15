using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented 
//as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class numberAsArray
{
    static void Main()
    {
        Console.WriteLine("Enter two integer numbers:");
        int NumberX = int.Parse(Console.ReadLine());
        int NumberY = int.Parse(Console.ReadLine());
        List<char> arrayX = NumberX.ToString().ToList();
        List<char> arrayY = NumberY.ToString().ToList(); 
        int result=Adding(arrayX,arrayY);
        Console.WriteLine("The result of adding the two numbers is:");
        Console.WriteLine(result);
    }
    
    static int Adding(List<char> arrayX, List<char> arrayY)
    {
        arrayX.Reverse();
        arrayY.Reverse();
        bool XisBigger = arrayX.Count > arrayY.Count;
        if (XisBigger)
        {
            for (int i = arrayY.Count; i < arrayX.Count; i++)
            {
                arrayY.Add('0');
            }            
        }
        else
        {
            for (int i = arrayX.Count; i < arrayY.Count; i++)
            {
                arrayX.Add('0');
            }  
        }
        List<int> comb=new List<int>();
        int adding = 0;
        for (int i = 0; i < arrayY.Count;i++)
        {
            int temp= arrayX[i] + arrayY[i] - 96;
            comb.Insert(i, temp+adding);
            if (comb[i] > 9)
            {
                adding = 1;
                comb[i] = comb[i] - 10;
            }
            else
            {
                adding = 0;
            }
            if (adding == 1&&i==arrayX.Count-1)
            {
                comb.Add(1);
            }
        }
        string rawString=string.Join("",comb);
        string reversedString = Reverse(rawString);
        int finalInt = int.Parse(reversedString);
        return finalInt;
    }
    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

