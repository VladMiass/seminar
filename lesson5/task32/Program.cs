int[] GetRandomArray()
{
    int[] array = new int[5];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] MyArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", MyArray)}]");
for (int i = 0; i < MyArray.Length; i++) MyArray[i] = -MyArray[i];
Console.WriteLine($"[{string.Join(", ", MyArray)}]");