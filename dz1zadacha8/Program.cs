﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("ВВедите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

if (N>1)
{
     while (i<N+1)
     {
           if (i%2==0)
           {
                Console.Write(" "+ i +" "); 
           }
           else
           {
         // пустая команда, ничего не делаем, идем к счетчику i+1 и возвращемся в цикл
           }
           i=i+1;
     }
}
else
{
Console.Write("Неверно, введите число больше 1"); 
}