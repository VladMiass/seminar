int SummaTsifr(int Chislo)
{
if (Chislo <= 0) return 0;
return SummaTsifr(Chislo / 10) + (Chislo % 10);
}

int number = 45;
Console.Write(SummaTsifr(number));
