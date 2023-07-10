int Ackerman(int N, int M)
{
    if(N == 0) return M + 1;
    else
    {
        if(M == 0) return Ackerman(N - 1, 1);
        else
        {
            if(N > 0 && M > 0) return Ackerman(N - 1, Ackerman(N, M -1));
        }
    }
    Console.WriteLine("Не вычислено");
    return 0;
}

int N = 3;
int M = 3;
int S = 0;
S = Ackerman(N, M);
Console.Write("Функция Аккермана для N = " + N + " и M = " + M + " равна " + S);