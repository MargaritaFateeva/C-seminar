// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return Akkerman (m-1,1);
    else return Akkerman (m-1,Akkerman (m,n-1));
}
Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
while (m<0 || n<0) 
{
    Console.WriteLine ("!Ошибка, введите неотрицательные числа m и n");
    Console.WriteLine("Введите число m: ");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число n: ");
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine($"M = {m}; N = {n} -> A(m,n) = {Akkerman(m, n)}");