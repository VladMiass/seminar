int[,,] GetRandomMatrix3(int rowX, int rowY, int rowZ)
{
int[,,] matrix = new int[rowX, rowY, rowZ];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int k = 0; k < matrix.GetLength(2); k++)
            matrix[i, j, k] = Random.Shared.Next(10, 100);
    }
}
return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} {i}{j}{k}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

const int RowX = 2;
const int RowY = 3;
const int RowZ = 4;
int[,,] myMatrix = GetRandomMatrix3(RowX, RowY, RowZ);
PrintMatrix(myMatrix);
