int ReadInt(string msg)
{ 
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = ReadInt("Ввести " + (i + 1) + " элемент: ");
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "  ");
}
