int ReadInt()
{
    Console.WriteLine("Введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadInt();
int M = N;
int i = 0;
while(N > 0)
{
    N = N / 10;
    i++;
}
Console.WriteLine($"В числе {M} {i} цифр");