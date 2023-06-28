Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int m = 0;
string n = "";
while(num != 0)
{
    m = num % 2;
    num = num / 2;
    n = m + n;
}
Console.WriteLine(n);