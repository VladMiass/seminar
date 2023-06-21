int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(0, 2);
    Console.Write(array[i] + "  ");
}
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Ввести первое число: ");