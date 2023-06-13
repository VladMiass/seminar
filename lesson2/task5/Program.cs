Console.WriteLine("Введите первое число:");
string? numberString = Console.ReadLine()!;
int numberInt1 = Convert.ToInt32(numberString);
Console.WriteLine("Введите второе число:");
numberString = Console.ReadLine()!;
int numberInt2 = Convert.ToInt32(numberString);
if(numberInt2 * numberInt2 == numberInt1 || numberInt1 * numberInt1 == numberInt2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
