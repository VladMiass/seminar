void Perechislenie(int FirstNumber, int LastNumber)
{
    if(LastNumber < FirstNumber) return;
    Perechislenie(FirstNumber, LastNumber - 1);
    Console.Write(LastNumber + " ");
}

int M = 4;
int N = 8;
Perechislenie(M, N);