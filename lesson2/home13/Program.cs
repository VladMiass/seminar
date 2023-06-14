Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine()!;
int number = Convert.ToInt32(numberString);
int i = 0;
int m = 0;
int res = 0;
if(number > 99)
{
    while(Math.Pow(10, i) <= number)
    {
        m = i;
        Console.WriteLine(m + "  " + i);
        i++;
    }
    m = m - 2;
    res = (int)(number / Math.Pow(10, m));
    res = res % 10;
    Console.WriteLine("третья цифра:  " + res);
}
else Console.WriteLine("третьей цифры нет");
