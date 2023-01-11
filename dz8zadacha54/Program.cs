// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] GetArray(int m, int n) // создание массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray1(int[]arr) // вывод одномерного  массива
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void PrintArray2(int[,] inArray) // вывод двумерного  массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int [] SortMaxToMin(int[]inArray) // сортировка одномерного массива по убыванию
{                                 // (по возрастанию потом переворот)
    Array.Sort(inArray);
    int [] sort = new int[inArray.Length];
    for(int i=0; i<inArray.Length; i++)
    {
        sort[i]=inArray[inArray.Length-1-i];
    }
    return sort;
}

int [,] GetSortRowsArray (int[,] inArray) // упорядочиваем по убыванию элементы                
{                                         // каждой строки исходного массива
    int [,] sort = new int [inArray.GetLength(0),inArray.GetLength(1)];
    int [] sortrows = new int [inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // создаем из строки 
        {                                              // одномерный массив
            sortrows[j] =  inArray[i,j];
            // Console.Write($"{sortrows[j]} "); // вывод для проверки
        }
        // Console.WriteLine();                  // вывод для проверки
        for (int j = 0; j < inArray.GetLength(1); j++) // сортировка строки
        {                                              // по убыванию
            sortrows = SortMaxToMin(sortrows);
            sort [i,j] = sortrows[j];
            // Console.Write($"{sort [i,j]} "); // вывод для проверки
        }
        // Console.WriteLine();                  // вывод для проверки
        // Console.WriteLine();                  // вывод для проверки
    }
    return sort;
}

int[,] array = GetArray(rows, columns);
PrintArray2(array);
Console.WriteLine();
PrintArray2(GetSortRowsArray(array));