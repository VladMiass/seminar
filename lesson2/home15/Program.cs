Console.WriteLine("Введите день недели:");
string? numberString = Console.ReadLine()!;
int numberInt = Convert.ToInt32(numberString);
switch(numberInt)
{
    case 1:
        Console.WriteLine("нет");
        break;
    case 2:
        Console.WriteLine("нет");
        break;
    case 3:
        Console.WriteLine("нет");
        break;
    case 4:
        Console.WriteLine("нет");
        break;
    case 5:
        Console.WriteLine("нет");
        break;
    case 6:
        Console.WriteLine("да");
        break;
    case 7:
        Console.WriteLine("да");
        break;
    default:
        Console.WriteLine("такого дня нет");
        break;
}