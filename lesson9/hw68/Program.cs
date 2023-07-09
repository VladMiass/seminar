int Perechislenie(int FirstNumber, int LastNumber)
{
    if(FirstNumber >= LastNumber) return FirstNumber;
    return FirstNumber + Perechislenie(FirstNumber + 1, LastNumber);
}

int M = 1;
int N = 15;
int S = 0;
S = Perechislenie(M, N);
Console.Write("Сумма цифр = " + S);