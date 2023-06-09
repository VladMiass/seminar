﻿const int ROWS = 3;
const int COLUMNS = 4;

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int DiagMatrix(int[,] matrix)
{
    int sum = 0;
    int len = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    for(int i = 0; i < len; i++)
    {
        sum = sum + matrix[i, i];
    }
    return sum;
}

int[,] myMatrix = GetMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine(DiagMatrix(myMatrix));
