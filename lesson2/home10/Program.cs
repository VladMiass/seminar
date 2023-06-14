Console.WriteLine("Введите число:");
string? numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
numberInt = (numberInt - numberInt / 100 * 100) / 10;
Console.WriteLine(numberInt);