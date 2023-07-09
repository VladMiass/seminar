void PrintBinaryView(int decNumber)
{
    if (decNumber <= 0) return;
    PrintBinaryView(decNumber / 2);
    Console.Write(decNumber % 2);
}

int number = 13;
PrintBinaryView(number);
