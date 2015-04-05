using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 5. Maximal area sum
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//
//Example:
//input 	output
//4
//2 3 3 4
//0 2 3 4
//3 7 1 2
//4 3 3 2 	17

class MaximalAreaSum
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\matrix.txt");

        using (reader)
        {         
            int number = int.Parse(reader.ReadLine());



            string[] array = new string[number];
            for (int i = 0; i < number; i++)
            {

                array[i] = reader.ReadLine();

            }
            int[,] matrix = new int[number, number];
            for (int m = 0; m < number; m++)
            {
                string[] row = array[m].ToString().Split(' ');
                for (int n = 0; n < number; n++)
                {
                    matrix[m, n] = int.Parse(row[n]);
                    // Console.Write(matrix[m,n]);
                }
                //Console.WriteLine();
            }
            int currentSum = 0;
            int maxSum = int.MinValue;
            for (int k = 0; k < number - 1; k++)
            {
                for (int l = 0; l < number - 1; l++)
                {

                    currentSum = matrix[k, l] + matrix[k + 1, l] + matrix[k, l + 1] + matrix[k + 1, l + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }

                }
            }
            StreamWriter writer = new StreamWriter(@"..\..\max.txt");
            using (writer)
            {
                writer.Write("Maximal sum is: {0}", maxSum);
            }
            Console.WriteLine(maxSum);
        }
    }
}


