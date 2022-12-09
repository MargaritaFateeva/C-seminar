// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"Произведение чисел = {GetMulti(num)}");

int GetMulti (int number)
{
    int comp = 1;
    while (number>0)
    {
        Console.Write($" {number} ");
        comp = comp*number;
        number--;
    }
    return comp;
}
