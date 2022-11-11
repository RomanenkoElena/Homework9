// 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int N = new Random().Next(1, 100);
Console.WriteLine($"Ввод числа N = {N}");
string result = NumRec (N);
Console.WriteLine($"Все числа от N до 1: {result}");

string NumRec(int N)
{
    if (N == 1) return "1";
    else return N + "," + NumRec(N-1);
}