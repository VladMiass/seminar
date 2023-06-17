Console.WriteLine("введите пятизначное число:");
int n5 = Convert.ToInt32(Console.ReadLine());
int nn = n5;
int res = 0;
for(int i = 0; i < 5; i++)
{
    res = res * 10 + n5 % 10;
    n5 = n5 / 10;
    Console.WriteLine(i + "  " + n5 + "  " + res);
}
if(nn == res) Console.WriteLine(" палиндром ");
else Console.WriteLine("  не палиндром ");