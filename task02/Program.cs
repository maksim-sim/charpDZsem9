int ReadInt(string mes){
    Console.Write(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int PrintEvenNumbers(int M, int N)
{
    if (M == N) return M;
    else return M + PrintEvenNumbers(M + 1, N);
}


int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");

Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {PrintEvenNumbers(M, N)}");