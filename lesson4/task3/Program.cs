int ReadInt()
{
    Console.WriteLine("Введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Multiplay(int N)
{
    int mult = 1;
    for(int i = 1; i <= N; i++)
    {
        mult *=i;
    }
    return mult;
}

int number = ReadInt();
Console.WriteLine($"Произведение чисел от 1 до {number} = {Multiplay(number)}");