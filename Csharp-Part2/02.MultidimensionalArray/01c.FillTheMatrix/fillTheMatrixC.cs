using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//
//Example for n=4:
//c)
//	
//7 	11 	14 	16
//4 	8 	12 	15
//2 	5 	9 	13
//1 	3 	6 	10


class FillTheMatrixC
{
    static void Main()
    {
        Console.WriteLine("Enter the n for a matrix(n,n):");
        int n = int.Parse(Console.ReadLine());
        int[,] matrixC = new int[n, n];
        int[,] listOfDiffs = new int[n,n-1];
        List<int> listOfStartNumbers = new List<int>();
        listOfStartNumbers.Add(1);
        List<int> nPos=new List<int>();
        for (int i = 1; i < n; i++)
        {
            listOfStartNumbers.Add(listOfStartNumbers[i - 1] + i);
            //Console.WriteLine(listOfStartNumbers[i]);
        }
        int middle = n / 2;
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n-1; j++)
            {
                if (j + 1 == i || j == i)
                {
                    listOfDiffs[i, j] = n;                   
                }              
            }           
         }
        bool isChecked = false;
        bool leftFinished = false;
        bool rightFinished = false;
        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (leftFinished == true&&rightFinished==false&&listOfDiffs[i,j]==0)
                {
                    listOfDiffs[i,j] = listOfDiffs[n-1-i,n-2-j];
                    if (i == n - 1 && j == n - 2)
                    {                        
                        rightFinished = true;
                    }
                }
                if (leftFinished == false && rightFinished == false)
                {
                    if (listOfDiffs[i, j] == n && j > 0 && listOfDiffs[i, j - 1] != n && isChecked == false)
                    {
                        nPos.Add(j);
                        j = 0;
                        isChecked = true;
                    }
                    if (isChecked == true && j < nPos[0])
                    {
                        listOfDiffs[i, j] = n - nPos[0] + j;
                    }
                    else
                    {
                        isChecked = false;
                        nPos.Clear();
                        if (i == n - 1 && j == n - 2)
                        {
                            i = 0;
                            j = 0;
                            leftFinished = true;
                        }
                    }
                }
            }            
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0)
                {
                    matrixC[i, j] = listOfStartNumbers[n - 1 - i];
                    Console.Write("{0,3}", matrixC[i, j]);
                }
                else
                {
                    matrixC[i, j] = matrixC[i, j - 1] + listOfDiffs[i, j-1];
                    Console.Write("{0,3}",matrixC[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}

