const int ROWS = 3;
const int COLUMNS = 4;

float[,] GetRandomArray(int rows, int columns)
{
    float[,] matrix = new float[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextSingle() * 100;
        }     
    }
    return matrix;
}

void PrintMatrix(float[,] matrix)
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

float[,] myMatrix = GetRandomArray(ROWS, COLUMNS);
PrintMatrix(myMatrix);
Console.WriteLine("Введи через пробел номер строки и столбца");
string[] mn = Console.ReadLine().Split(" ");
int m = Convert.ToInt32(mn[0]);
int n = Convert.ToInt32(mn[1]);
if(m >= 0 && m < ROWS && n >= 0 && n < COLUMNS)
    Console.WriteLine("Элемент строка " + m + " столбец " + n + " равен " + myMatrix[m, n]);
else
    Console.WriteLine("Такого элемента нет");