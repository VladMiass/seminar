int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int first = number / 10;
int second = number % 10;
if(first > second)
{
    Console.WriteLine(first);
}
else if(second > first)
{
    Console.WriteLine(second);
}
else
{
    Console.WriteLine("числа равны");
}