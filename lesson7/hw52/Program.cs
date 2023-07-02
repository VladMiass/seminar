const int ROWS = 3;
const int COLUMNS = 4;

int[,] GetRandomArray(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            matrix[i, j] = Random.Shared.Next(1,100);
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

float[] AverageColumns(int[,] matrix, int columns)
{
    float[] array = new float[columns];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        array[j] = 0;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] = array[j] + matrix[i, j];
        }
        array[j] = array[j] / matrix.GetLength(0);
    }
    return array;
}

int[,] myMatrix = GetRandomArray(ROWS, COLUMNS);
float[] arrayAverage = AverageColumns(myMatrix, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine(string.Join(",  ", arrayAverage));
