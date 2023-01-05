// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetNumberDescending (int a, int b) //1 способ
{
    if (b<=a) return GetNumberDescending(a,b+1)+ $"{b} ";
    else return String.Empty;
}

void GetNumDescending (int a, int b) //2 способ
{
    if(b<a) GetNumDescending(a, b+1);
    Console.Write($"{b} ");
}

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(GetNumberDescending(n,1));

Console.WriteLine();
GetNumDescending(n,1);