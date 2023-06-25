int[] GetRandomArray()
{
    int[] array = new int[12];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] my_array = GetRandomArray();
int sum = 0;
for(int i = 0; i < my_array.Length; i++)
{
    if(i % 2 == 1) sum = sum + my_array[i];
}
Console.WriteLine(sum);
Console.WriteLine($"[{string.Join(", ", my_array)}]");