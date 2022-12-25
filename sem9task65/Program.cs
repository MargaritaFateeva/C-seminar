// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до M.

void NumbersFromMtoN(int m, int n)
{
    if (n>m) NumbersFromMtoN(m,n-1);
    if (m>n) NumbersFromMtoN(m,n+1);
    Console.Write($"{n} ");
}

NumbersFromMtoN(10,1);