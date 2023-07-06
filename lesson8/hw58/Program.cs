int[,] GetRandomMatrix(int row, int column)
{
int[,] matrix = new int[row, column];
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

int[,] MulOfMatrix(int[,] matrix1, int[,] matrix2)
{
    int row = matrix1.GetLength(0);
    int[,] matrix3 = new int[row, row];
    for(int i = 0; i < matrix3.GetLength(0); i++)
    {
        for(int j = 0; j < matrix3.GetLength(0); j++)
        {
            matrix3[i, j] = 0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }   
    return matrix3;
}

const int Rows = 3;
const int Columns = 4;
int[,] myMatrix1 = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix1);
Console.WriteLine("Первый");
int[,] myMatrix2 = GetRandomMatrix(Columns, Rows);
PrintMatrix(myMatrix2);
Console.WriteLine("Второй");
int[,] myMatrixM = MulOfMatrix(myMatrix1, myMatrix2);
PrintMatrix(myMatrixM);
