int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadInt("Ввести число: ");
int M = N;
int S = 0;
int L = 0;
    while(N >= 1)
    {
        L = N % 10;
        N = N / 10;
        S = S + L;
    }
Console.WriteLine($"Сумма цифр числа {M} = {S}");
