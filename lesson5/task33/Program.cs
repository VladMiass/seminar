int[] GetRandomArray()
{
    int[] array = new int[5];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] my_array = GetRandomArray();
bool YesNo = false;
Console.WriteLine("Введи число");
int number_find = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < my_array.Length; i++)
{
    if (number_find == my_array[i]) YesNo = true;
}
Console.WriteLine(YesNo);