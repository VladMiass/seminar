int[,] GetRandomArray(int row, int columns)
{
    int[,] matrix = new int[row, columns];   
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = Random.Shared.Next(1, 10);
    }
    return matrix;
}

int[] GetFrequencyOfElementsInMatrix(int[,] MyTwoDimensionalArray)
{
    int[] FrequencyArray = new int[10]; // [0,1,2,3,4,5,6,7,8,9]
    int rowCount = MyTwoDimensionalArray.GetLength(0);
    int columnCount = MyTwoDimensionalArray.GetLength(1);
    for (int i = 0; i < rowCount; ++i)
        for (int j = 0; j < columnCount; ++j)
            FrequencyArray[MyTwoDimensionalArray[i, j]]++;
    return FrequencyArray;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int rows = 5;
int columns = 7;
int[,] GMatrix = GetRandomArray(rows, columns);
PrintMatrix(GMatrix);
int[] GFrequency = GetFrequencyOfElementsInMatrix(GMatrix);
for (int i = 0; i < GFrequency.Length; ++i)
{
    Console.Write($"{i} : {GFrequency[i]} | ");
}
Console.WriteLine();