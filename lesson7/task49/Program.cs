const int ROWS = 3;
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
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void ChangeMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 != 0 && j % 2 != 0) matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
        
    }
}

int[,] myMatrix = GetMatrix(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine();
ChangeMatrix(myMatrix);
PrintMatrix(myMatrix);
