void Perechislenie(int FirstNumber, int LastNumber)
{
    if(FirstNumber > LastNumber) return;
    Perechislenie(FirstNumber + 1, LastNumber);
    Console.Write(FirstNumber + " ");
}

int M = 1;
int N = 8;
Perechislenie(M, N);