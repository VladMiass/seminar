int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Ввести первое число: ");
int B = ReadInt("Ввести второе число: ");
int S = A;
    for(int i = 2; i <= B; i++)
    {
        S = S * A;
    }
Console.WriteLine($"Число {A} в степени {B} = {S}");