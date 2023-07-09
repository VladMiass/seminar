int VozvedenieVStepen(int osnova, int mnozhytel)
{
    if(mnozhytel == 0) return 1;
    return VozvedenieVStepen(osnova , mnozhytel - 1) * osnova;
}

int number = 3;
int stepen = 5;
Console.Write(VozvedenieVStepen(number, stepen));
