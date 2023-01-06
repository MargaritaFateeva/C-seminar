// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumNumbersMtoN (int m, int n)
{
    if (m==n) return n; 
    else if (m>=n) return GetSumNumbersMtoN(m,n+1)+n;
    else return GetSumNumbersMtoN(m+1,n)+m;
}
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {m}; N = {n} -> {GetSumNumbersMtoN(m, n)}");