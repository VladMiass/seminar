Console.WriteLine("Введите первое число:");
string? numberString = Console.ReadLine()!;
int numberInt1 = Convert.ToInt32(numberString);
Console.WriteLine("Введите второе число:");
numberString = Console.ReadLine()!;
int numberInt2 = Convert.ToInt32(numberString);
int res = numberInt1 % numberInt2;
if(res == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет  " + res);
}
