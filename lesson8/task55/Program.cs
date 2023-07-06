const int Rows = 3;
const int Columns = 4;
int[,] GetRandomMatrix(int row, int columns)
{
int[,] matrix = new int[row, columns];   
for(int i = 0; i < matrix.GetLength(0); i++)   //i stroli     j stolbtsy
{
    for(int j = 0; j < matrix.GetLength(1); j++)    //гет лент - чисто строка
    {
        matrix[i, j] = Random.Shared.Next(1, 10);
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
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int[,] TranspositionMatrix(int row, int columns, int[,] matrix)
{
    int[,] matrixTrans = new int[row, columns];
    for(int i = 0; i < matrixTrans.GetLength(0); i++)
    {
        for(int j= 0; j < matrixTrans.GetLength(1); j++)
        {
            matrixTrans[i, j] = matrix[j, i];
        }
    }
    return matrixTrans;
}

int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
int[,] myMatrixTrans = TranspositionMatrix(Columns, Rows, myMatrix);
Console.WriteLine();
PrintMatrix(myMatrixTrans);
