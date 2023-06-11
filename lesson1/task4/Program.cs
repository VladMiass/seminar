Console.WriteLine("Введите трехзначное число:");
string? numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
numberInt = numberInt % 100 % 10;
Console.WriteLine(numberInt);