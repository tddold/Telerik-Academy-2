using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 7.* Largest area in matrix
//
//    Write a program that finds the largest area of equal neighbour 
//elements in a rectangular matrix and prints its size.
//
//Example:
//matrix 	result 13
//1 	3 	2 	2 	2 	4
//3 	3 	3 	2 	4 	4
//4 	3 	1 	2 	3 	3
//4 	3 	1 	3 	3 	1
//4 	3 	3 	3 	1 	1
//	

class LargestAreaInMatrix
{
    static void Main()
    {
        int[,] matrix = new int[,]{
        {1, 3, 2, 2, 2, 4},
        {3, 3, 3, 2, 4, 4},
        {4, 3, 1, 2, 3, 3},
        {4, 3, 1, 3, 3, 1},
        {4, 3, 3, 3, 1, 1}
        };
          search(matrix,0):
    }

    public static void search(int[,] matrix, int vertex)
    {
        bool isFound = true;

    }

  
//2      label v as discovered
//3      for all edges from v to w in G.adjacentEdges(v) do
//4          if vertex w is not labeled as discovered then
//5              recursively call DFS(G,w)
//
}

