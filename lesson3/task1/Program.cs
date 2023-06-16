Console.WriteLine("введите координату X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");
}
else
{
    Console.WriteLine("невозможно определить координатную четверть");
}