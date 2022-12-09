// Задача 26: Напишите программу, которая принимает на вход число и выдаёт 
// количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Число N {GetCountNum (N)}-значное");

int GetCountNum (int a)
{
    int count = 0;
    while (a>0)
    {
        a=a/10;
        count++;
    }
return count;
}