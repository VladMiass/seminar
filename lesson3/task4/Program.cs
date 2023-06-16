Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= num; i++)
{
    Console.WriteLine(i + "  " + Math.Pow(i, 2));
}