int ReadInt(string mes){
    Console.Write(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// A(0, n) = n + 1,
// A(1, n) = n + 2,
// A(2, n) = 2n + 3,
// A(3, n) = 2n+3 – 3
int Ackermann(int M, int N)
{
    if (M == 0) return N + 1; else
    if (M > 0 && N == 0) return Ackermann(M - 1, 1); else
    if (M > 0 && N > 0) return Ackermann(M - 1, Ackermann(M, N - 1));
    else return -1;
}


int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");

Console.WriteLine($"Результат вычисления функции Аккермана: {Ackermann(M, N)}");