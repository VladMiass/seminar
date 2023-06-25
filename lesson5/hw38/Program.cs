int[] GetRandomArray()
{
    int[] array = new int[12];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(1, 1000);
    }
    return array;
}

int[] my_array = GetRandomArray();
int i_min = 0, i_max = 0;
for(int i = 1; i < my_array.Length; i++)
{

    if(my_array[i] > my_array[i_max]) i_max = i;
    if(my_array[i] < my_array[i_min]) i_min = i;
}
Console.WriteLine($"max - min = {my_array[i_max] - my_array[i_min]}");
Console.WriteLine($"{string.Join(", ", my_array)}");