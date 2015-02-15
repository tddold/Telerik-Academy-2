using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 6.* Matrix class
//Write a class Matrix, to hold a matrix of integers.
//Overload the operators for adding, subtracting and multiplying of matrices,
//indexer for accessing the matrix content and ToString().


class MatrixClass
{
    private int[,] matrix;

    public MatrixClass(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }
    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    public static MatrixClass operator +(MatrixClass matrix1Par, MatrixClass matrix2Par)
    {
        MatrixClass resultMatrix = new MatrixClass(matrix1Par.Rows,matrix1Par.Cols);
        for (int row = 0; row < matrix1Par.Rows; row++)
        {
            for (int col = 0; col < matrix1Par.Cols; col++)
            {
                resultMatrix[row,col] =matrix1Par[row, col] + matrix2Par[row, col];
            } 
        }
        return resultMatrix;
    }

    public static MatrixClass operator -(MatrixClass matrix1Par, MatrixClass matrix2Par)
    {
        MatrixClass resultMatrix = new MatrixClass(matrix1Par.Rows, matrix1Par.Cols);
        for (int row = 0; row < matrix1Par.Rows; row++)
        {
            for (int col = 0; col < matrix1Par.Cols; col++)
            {
                resultMatrix[row, col] = matrix1Par[row, col] - matrix2Par[row, col];
            }
        }
        return resultMatrix;
    }

    public static MatrixClass operator *(MatrixClass matrix1Par, MatrixClass matrix2Par)
    {
        MatrixClass resultMatrix = new MatrixClass(matrix1Par.Rows, matrix1Par.Cols);
        for (int row = 0; row < matrix1Par.Rows; row++)
        {
            for (int col = 0; col < matrix1Par.Cols; col++)
            {
                resultMatrix[row, col] = matrix1Par[row, col] * matrix2Par[row, col];
            }
        }
        return resultMatrix;
    }

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col]=value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        string result = null;
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
               sb.Append(matrix[row, col]+" ");
            }
            sb.Append(Environment.NewLine);
        }
        
        result = sb.ToString();
        return result;
    }
}

