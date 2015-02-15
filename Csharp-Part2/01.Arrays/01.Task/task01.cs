using System;

//Problem 1. Allocate array.Write a program that allocates array of 20 integers and initializes each element by its index 
//multiplied by 5. Print the obtained array on the console.



class allocateArray
{
    static void Main()
    {
        int[] arrayOfInt = new int[20];
        for (int i=0; i < 20; i++)
        {
            arrayOfInt[i] = 5 * i;
            //Console.WriteLine("{0}->{1}",i,arrayOfInt[i]);
        }
        Console.WriteLine(string.Join((","),arrayOfInt));
    }
}
