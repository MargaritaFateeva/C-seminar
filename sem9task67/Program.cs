// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int GetSumNumb(int a)
{
    if (a > 0) a = a % 10 + GetSumNumb(a / 10);
    return (a);
}
Console.WriteLine("Введите число a: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(GetSumNumb(n));
