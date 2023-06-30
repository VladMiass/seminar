Console.WriteLine("Введи количество чисел:");
int num = Convert.ToInt32(Console.ReadLine());
int m = 0;
int count = 0;
for(int i = 1; i <= num; i++)
{
    Console.WriteLine(i + " число:");
    m = Convert.ToInt32(Console.ReadLine());
    if(m > 0) count++;
}
Console.WriteLine("Количество чисел больше 0: " + count);