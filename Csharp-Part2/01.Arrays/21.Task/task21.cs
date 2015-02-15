using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 21.* Combinations of set
//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//N 	K 
//5 	2 	
//{1, 2}
//{1, 3}
//{1, 4}
//{1, 5}
//{2, 3}
//{2, 4}
//{2, 5}
//{3, 4}
//{3, 5}
//{4, 5}

class task21
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] loops;

    static void Main()
    {
        Console.Write("N = ");
        numberOfIterations = int.Parse(Console.ReadLine());       
        Console.Write("K = ");
        numberOfLoops = int.Parse(Console.ReadLine()); 
        loops = new int[numberOfLoops];
        NestedLoops(0,1);
    }

    static void NestedLoops(int currentLoop,int start)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintLoops();
            return;
        }
        for (int counter = start; counter <= numberOfIterations; counter++)
        {
            loops[currentLoop] = counter;
            NestedLoops(currentLoop + 1,counter+1);
        }
    }


    static void PrintLoops()
    {
        for (int i = 0; i < numberOfLoops; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}

