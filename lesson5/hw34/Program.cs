int[] GetRandomArray()
{
    int[] array = new int[12];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(99, 1000);
    }
    return array;
}

int[] my_array = GetRandomArray();
int count = 0;
for(int i = 0; i < my_array.Length; i++)
{
    if(my_array[i] % 2 == 0) count++;
}
Console.WriteLine(count);
Console.WriteLine($"[{string.Join(", ", my_array)}]");
