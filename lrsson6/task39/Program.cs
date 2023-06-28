int[] GetRandomArray(int lengh, int leftRange, int rightRange)
{
    int[] array = new int[lengh];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

void ReverseArray(int[] sourceArray)
{
    for(int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i - 1];
        sourceArray[sourceArray.Length - i - 1] = temp;
    }
}

const int length = 5;
const int leftRandomBorder = -9;
const int rightRandomBorder = 10;
int[] myArray = GetRandomArray(length, leftRandomBorder, rightRandomBorder);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));