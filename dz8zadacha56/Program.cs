// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк матрицы: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = int.Parse(Console.ReadLine());

while (columns == rows)// проверка ввода данных на прямоугольный массив
{
    Console.WriteLine("!Ошибка, матрица должна быть прямоугольной");
    Console.Write("Введите количество строк матрицы: ");
    rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы: ");
    columns = int.Parse(Console.ReadLine());
}

int[,] GetArray(int m, int n)
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

void PrintArray(int[,] inArray)
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

int [,] GetSumElementRows (int [,] inArray) // столбец с суммами по строкам матрицы
{
    int sum=0;
    int [,] result = new int [inArray.GetLength(0), 1];
    for (int i=0; i<inArray.GetLength(0);i++)
    {
        for (int j=0; j<inArray.GetLength(1); j++)
        {
            sum=sum+inArray[i,j];
            result[i,0]=sum;
        }
        sum=0;
    }
    return result;
}

int FindMinElement(int[,] inArray) // находим минимальный элемент массива и его строку
{
    int min = inArray[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < min)
            {
                minI = i;
                minJ = j;
                min = inArray[i, j];
            }
        }
    }  
    int rows = minI+1; // номер строки = индекс+1 (тк индексы с 0 начинаются, а
    return rows;       // а строки в матрице с 1 строки
}

Console.WriteLine();
int [,] matrix = GetArray(rows, columns);
PrintArray(matrix);
Console.WriteLine();
int[,] RowsSum = GetSumElementRows(matrix);
// PrintArray(RowsSum);
int numrows = FindMinElement(RowsSum);
Console.WriteLine($"№ строки с наименьшей суммой элементов: {numrows} строка матрицы");