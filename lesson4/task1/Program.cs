int ReadInt()
{
    Console.WriteLine("Введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Summa(int N)
{
    int sum = 0;
    for(int i = 1; i <= N; i++)
    {
        sum +=i;
    }
    return sum;
}

int number = ReadInt();
Console.WriteLine($"Сумма чисел от 1 до {number} = {Summa(number)}");