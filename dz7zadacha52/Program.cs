// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] CreateArray(int a, int b)
{
    double[,] matrix = new double [a, b];
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

void PrintArray(double[]arr)
{
    for(int i=0; i<arr.Length; i++)
    {
            Console.Write($"{arr[i]} ");
    }
        Console.WriteLine();
}


double[] AveragreToColumns(double[,] array)
{ 
    double [] averagre = new double [array.GetLength(1)];
    for (int column = 0; column < array.GetLength(1); column++)
    {
        double sum=0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sum = sum+array[rows,column];
        }
        averagre[column] = sum/array.GetLength(0);  
    }
    Console.Write("Среднее арифметическое по столбцам: ");
    return averagre;
    
}

double [,] arr = CreateArray(5,4);
PrintArray(AveragreToColumns(arr));
