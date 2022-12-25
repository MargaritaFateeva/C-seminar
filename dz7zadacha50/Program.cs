// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 
// 1- строка и 7 -столбец)

int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
        matrix[rows, columns] = new Random().Next(1,10);
        Console.Write($"{matrix[rows, columns]} ");
        }
    Console.WriteLine("");
    }
Console.WriteLine("");
return matrix;
}

void ShowElement(int[,] array, int a, int b)
{
    if(array.GetLength(0)<=a || array.GetLength(1)<=b || a<0 || b<0) 
            {
                Console.WriteLine("Такого Элемента в массиве нет");
            }
            else Console.WriteLine($"Элемент [{a},{b}] = {array[a, b]} ");
}

Console.WriteLine("Введите номер строки");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int b = int.Parse(Console.ReadLine());
int[,]arr = CreateArray(5,5);
ShowElement(arr, a, b);
