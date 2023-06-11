int Max(int a, int b, int c)
{
    int res = a;
    if(b > res) res = b;
    if(c > res) res = c;
    return res;
}

Console.WriteLine("Введите первое число:");
int numberInt1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberInt2 = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine("Введите третье число:");
int numberInt3 = Convert.ToInt32(Console.ReadLine());;
Console.WriteLine($"максимальное число: {Max(numberInt1, numberInt2, numberInt3)}");