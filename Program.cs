// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Введит м; ");
// int M = int.Parse(Console.ReadLine()!);

// Console.WriteLine (Pow (M, 1));
// string Pow (int start, int end)
// {   
//     if (start == end) return start.ToString();
//     return (start + " " + Pow (start - 1, end));
// }


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введит M; ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введит N; ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(Pow(M, N));
int Pow(int N, int M)
{
    if (N-1 == M) return 0;
    return (N + Pow(N+1, M));
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Add m; ");
int ValueM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Add n; ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"A({ValueM},{n}) ->> " + AkkermanFunc(ValueM, n));
int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AkkermanFunc(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunc(m-1,AkkermanFunc(m,n-1));
    return AkkermanFunc(m,n);
}
