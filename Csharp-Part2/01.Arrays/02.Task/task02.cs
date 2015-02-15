using System;
using System.Collections.Generic;
//Problem 2. Compare arrays.Write a program that reads two arrays from the console and compares them element by element.

class compareArray
{

    static void Main()
    {
        List<int> listOfInt1 = new List<int>();
        List<int> listOfInt2 = new List<int>();
        bool isEqual = false;
        Console.WriteLine("Enter the first array (enter \"end\" when you want to end it)");
        for (int i = 0; i < 1; )
        {
            string type = Console.ReadLine();
            i = (type == "end") ? 1 : 0;
            if (type == "end")
            {
                break;
            }
            else
            {
                listOfInt1.Add(int.Parse(type));
            }
        }
        Console.WriteLine("Enter the second array (enter \"end\" when you want to end it)");
        for (int i = 0; i < 1; )
        {
            string type = Console.ReadLine();
            i = (type == "end") ? 1 : 0;
            if (type == "end")
            {
                break;
            }
            else
            {
                listOfInt2.Add(int.Parse(type));
            }
        }
        isEqual = listOfInt1.Count != listOfInt2.Count ? false : true;
        if (listOfInt1.Count == listOfInt2.Count)
        {
            int diff = 0;
            for (int index = 0; index < listOfInt1.Count; index++)
            {

                if (listOfInt1[index] != listOfInt2[index])
                {
                    isEqual=false;
                }
            }
            //isEqual = diff == 0 ? true : false;
        }
        if (isEqual == true)
        {
            Console.WriteLine("The two arrays are equal");
        }
        else
        {
            Console.WriteLine("The two arrays are NOT equal");
        }
    }
}
