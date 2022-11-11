// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = new Random().Next(2, 4);
int n = new Random().Next(2, 4);
Console.WriteLine($"Введены числа m = {m} и n = {n}");
int result = Akkerman(m, n);
Console.Write($"Функция Аккермана = {result} ");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
