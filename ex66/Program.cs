// 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = new Random().Next(1, 10);
int N = new Random().Next(1, 10);
Console.WriteLine($"Ввод числа M = {M}");
Console.WriteLine($"Ввод числа N = {N}");
int result = SumRecursive(M, N);
Console.WriteLine($"Сумма чисел от M до N: {result}");

int SumRecursive (int M, int N)
{
    if (N == M) 
    {
        return N;
    }
    else 
    {
        if (N < M)
        {
            return M + SumRecursive(N, M-1);
        } 
        else
        {
            return M + SumRecursive(N, M+1);
        }
    }
}