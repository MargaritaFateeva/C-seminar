// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы 1: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1: ");
int columns1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк матрицы 2: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2: ");
int columns2 = int.Parse(Console.ReadLine());

while (columns1 != rows2)// проверка ввода данных
{
    Console.WriteLine("!Ошибка, произведение матриц невозможно, введите новые значения");
    Console.Write("Введите количество строк матрицы 1: ");
    rows1 = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы 1: ");
    columns1 = int.Parse(Console.ReadLine());

    Console.Write("Введите количество строк матрицы 2: ");
    rows2 = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов матрицы 2: ");
    columns2 = int.Parse(Console.ReadLine());
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 4);
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

int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)// универсальный метод
{                                                            // матрицы 4*2 и 2*3;  
                                                             // 1*2 и 2*3 тоже умножит
    int [,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    sum = sum + matrix1[i,n]*matrix2[n,j];
                    result[i, j] = sum;
                }
                sum=0;            
        }
    }
    return result;
}

int [,] matrix1 = GetArray(rows1, columns1);
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
int [,] matrix2 = GetArray(rows2, columns2);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матрицы 1 и матрицы 2:");
PrintArray(GetMatrixMultiplication(matrix1,matrix2));