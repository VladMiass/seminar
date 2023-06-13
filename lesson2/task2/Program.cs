int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int first = number / 100;
int second = number % 10;
//first * 10 + second
    Console.WriteLine(first * 10 + second);
