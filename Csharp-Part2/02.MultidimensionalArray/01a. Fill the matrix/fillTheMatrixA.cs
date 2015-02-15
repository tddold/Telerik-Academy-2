using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//
//Example for n=4:
//a) 	b) 	c) 	d)*
//1 	5 	9 	13
//2 	6 	10 	14
//3 	7 	11 	15
//4 	8 	12 	16

class FillTheMatrix_a
{
    static void Main()
    {
       Console.WriteLine("Enter the n for a matrix(n,n):");
       int n=int.Parse(Console.ReadLine());
       int[,] matrixA=new int[n,n];
       for (int i = 0; i < n; i++)
       {
           for (int j = 0; j < n; j++)
           {
               matrixA[i, j] = i + 1 + n*j;
               Console.Write("{0,3}",matrixA[i,j]);
           }
           Console.WriteLine();
       }
       Console.WriteLine();        
    }
}

