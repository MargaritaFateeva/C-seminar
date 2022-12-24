// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

void CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < a; rows++)
    {
        for (int columns = 0; columns < b; columns++)
        {
            matrix[rows, columns] = rows+columns;
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

CreateArray(3,4);