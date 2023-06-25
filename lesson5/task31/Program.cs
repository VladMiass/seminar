int[] GetRandomArray()
{
    int[] array = new int[12];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int SumPositivElements(int[] massive)
{
    int SumOfPositiveElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] > 0) SumOfPositiveElements = SumOfPositiveElements + massive[i];
    }
    return SumOfPositiveElements;
}

int SumNegativElements(int[] massive)
{
    int SumOfNegativeElements = 0;
    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i] < 0) SumOfNegativeElements = SumOfNegativeElements + (-massive[i]);
    }
    return SumOfNegativeElements;
}

int[] MyArray = GetRandomArray();
Console.WriteLine($"[{string.Join(", ", MyArray)}]");
int SumPositive = SumPositivElements(MyArray);
int SumNegative = SumNegativElements(MyArray);
Console.WriteLine($"SumPositiveElements = {SumPositive}");
Console.WriteLine($"SumNegativeElements = {SumNegative}");