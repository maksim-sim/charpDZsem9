int ReadInt(string mes){
    Console.Write(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintEvenNumbers(int M, int N)
{
    if (M > N){
        Console.WriteLine();
        return;
    }

    if (M % 2 == 0) Console.Write(M + "\t");
    PrintEvenNumbers(M + 1, N);
}


int M = ReadInt("Введите значение M: ");
int N = ReadInt("Введите значение N: ");

Console.WriteLine($"Чётные числа от {M} до {N}:");
PrintEvenNumbers(M, N);