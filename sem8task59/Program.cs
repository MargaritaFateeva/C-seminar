// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
PrintArray(NewArray(array, FindMinElement(array)));

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
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int[] FindMinElement(int[,] Matrix) // находим минимальный элемент массива и его индексы
{
    int min = Matrix[0, 0];
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            if (Matrix[i, j] < min)
            {
                minI = i;
                minJ = j;
                min = Matrix[i, j];
            }
        }
    }  
    int[] Temporary = { minI, minJ }; // координаты строчки и столбца
    return Temporary;
}

int[,] NewArray(int[,] OriginalArray, int[] Coordinati)
{
    int newrow = 0;
    int newcolumn = 0;
    int[,] result = new int[OriginalArray.GetLength(0) - 1, OriginalArray.GetLength(1) - 1];
    for (int i = 0; i < OriginalArray.GetLength(0); i++)
    {
        if (i != Coordinati[0])
        {
            for (int j = 0; j < OriginalArray.GetLength(1); j++)
            {
                if (j != Coordinati[1])
                {
                    result[newrow, newcolumn] = OriginalArray[i, j];
                    newcolumn++;
                }
            }
            newrow++;
            newcolumn = 0;
        }
    }
    return result;
}
