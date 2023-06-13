Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
if(numberInt % 7 == 0 && numberInt % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}