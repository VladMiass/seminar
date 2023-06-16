Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine()!;
int number = Convert.ToInt32(numberString);
if(number > 99)
{
    while(number > 999)
    {
        number /= 10;
    }
number = number % 10;
Console.WriteLine("третья цифра:  " + number);
}
else Console.WriteLine("третьей цифры нет");
