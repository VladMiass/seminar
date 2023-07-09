void Perechislenie(int LastNumber)
{
    if(LastNumber < 1) return;
    Perechislenie(LastNumber - 1);
    Console.Write(LastNumber + " ");
}

int number = 6;
Perechislenie(number);