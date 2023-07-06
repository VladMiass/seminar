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

int SumOfMatrix(int[,] matrix)
{
    int sum = 0;
    int sumOfColumn = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[0, j];
    }
    for(int i = 1; i < matrix.GetLength(0); i++)
    {
        sumOfColumn = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfColumn = sumOfColumn + matrix[i, j];
        }
        if(sum > sumOfColumn) sum = sumOfColumn;
    }
    return sum;
}

const int Rows = 3;
const int Columns = 4;
int[,] myMatrix = GetRandomMatrix(Rows, Columns);
PrintMatrix(myMatrix);
Console.WriteLine();
Console.WriteLine(SumOfMatrix(myMatrix));