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

const int n = 4;
const int m = 5;
int[,] matrix = new int[n, m];
int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = m;
for (int i = 0; i < n * m; i++)
{
    matrix[row, col] = i + 1;
    visits--;
    if (visits == 0)
    {
        visits = m * (dirChanges %2) + n * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}
PrintMatrix(matrix);