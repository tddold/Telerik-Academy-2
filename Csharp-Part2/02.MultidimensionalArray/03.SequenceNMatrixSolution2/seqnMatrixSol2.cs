﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class seqnMatrixSol2
{
    static void Main()
    {
        Console.WriteLine("N and M sides of the m,atrix:");
        //int numberN=int.Parse(Console.ReadLine());
        //int numberM=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the matrix:");
        int numberN = 3;
        int numberM = 3;
        string[,] matrix = new string[3, 4]
        {
            {"ha","fifi","ho","hi"},
            {"fo","ha","hi","xx"},
            {"xxx","ho","ha","xx"}           
        };
        int smallest = numberN > numberM ? numberM : numberN;
        //string[,] matrix=new string[numberN,numberM];
        //for (int i = 0; i < numberN; i++)
        //{
        //    for (int j = 0; j < numberM; j++)
        //    {
        //        matrix[i.j] = Console.ReadLine();
        //    }
        //}
        int countOfEqualElements = 0;
        int currentRightDiagonalElements = 0;
        int currentLeftDiagonalElements = 0;
        int currentHorizontalElements = 0;
        int currentVerticalElements = 0;
        string currentChecked = "";
        string finalEqual = "";
        for (int i = 0; i < numberN; i++)
        {
            for (int j = 0; j < numberM; j++)
            {
            }
        }
    }

    static void checker(int[,] matrix,int smallest)
    {
    for (int offset = 0; offset < smallest; offset++)
                {
                    if (offset + j >= numberM || offset + i >= numberN)
                    {
                        break;
                    }
                    if (matrix[i, j].Equals(matrix[i + offset, j + offset]))
                    {
                        currentLeftDiagonalElements++;
                        currentChecked = matrix[i, j];
                    }
                    else
                    {
                        break;
                    }
                }
    }


}
        
        

