int[] my_array = {1, 2, 6, 5, 9};
int[] new_array = new int[(my_array.Length + 1) / 2];
for (int i = 0; i < (my_array.Length + 1) / 2; i++)
{
    if (i == my_array.Length - 1 - i)  new_array[i] = my_array[i];
    else new_array[i] = my_array[i] * my_array[my_array.Length - 1 - i];
}
Console.WriteLine($"[{string.Join("  ", my_array)}]");
Console.WriteLine($"[{string.Join("  ", new_array)}]");