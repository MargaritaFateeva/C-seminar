﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N%2==0)
{
    Console.Write("Является ли число чётным: ДА");
}
else 
{
    Console.Write("Является ли число чётным: НЕТ");
}