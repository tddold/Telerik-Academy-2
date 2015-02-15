using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1b. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:

//b)	
//1 	8 	9 	16
//2 	7 	10 	15
//3 	6 	11 	14
//4 	5 	12 	13

class FillTheMatrixB
{
    static void Main(string[] args)
    {
        int count = 1;
        Console.WriteLine("Enter the n for matrix(n,n):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixB = new int[n, n];
        int[] listOfDiffs = new int[n-1];
        for (int m = 0; m < listOfDiffs.Length; m++)
        {
            listOfDiffs[m] = m % 2 == 0 ? 2 * n - 1 : 1;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    matrixB[i, j] = count;
                    count++;
                }
                else
                {
                    matrixB[i, j] = matrixB[i, j - 1] + listOfDiffs[j-1];                    
                }
                if (j > 0 && j < n)
                {
                    listOfDiffs[j-1] = (j-1) % 2 == 0 ? listOfDiffs[j-1] - 2 : listOfDiffs[j-1] + 2;
                }
                Console.Write("{0,3}", matrixB[i, j]);
            }
            Console.WriteLine();
        }
    }
}

