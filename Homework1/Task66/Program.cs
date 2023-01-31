// Задача 66: Напишите программу, 
// которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int result = GetSum(1, 15);
Console.WriteLine(result);

int GetSum (int M, int N)
{
    if(M == N ) return N;
    else
    {
        return GetSum(M+1, N)+ M;
    }
}