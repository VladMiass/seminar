Console.WriteLine("Введите первое число:");
string? numberString = Console.ReadLine()!;
int numberInt1 = Convert.ToInt32(numberString);
Console.WriteLine("Введите второе число:");
numberString = Console.ReadLine()!;
int numberInt2 = Convert.ToInt32(numberString);
if(numberInt1 == numberInt2)
{
    Console.WriteLine("числа равны");
}
else if(numberInt1 < numberInt2)
{
    Console.WriteLine($"numberInt1= {numberInt1} меньше numberInt2= {numberInt2}");
}
else
{
    Console.WriteLine($"numberInt1= {numberInt1} больше numberInt2= {numberInt2}");
}