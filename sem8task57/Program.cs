// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();
FrequencyDictionary(
SortArray(
CreateSingleArray(array)));

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

int[] CreateSingleArray(int[,] inArray)
{
    int k = 0;
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k] = inArray[i, j];
            Console.Write(result[k] + " ");
            k++;
        }
    }
    Console.WriteLine();
    return result;
}

int[] SortArray(int[] inArray)
{
    Array.Sort(inArray);
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    return inArray;
}

void FrequencyDictionary(int[] newarray)
{
    int count = 1;
    int solveelement = newarray[0];
    for (int i = 1; i < newarray.Length; i++)
    {
        if (solveelement == newarray[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"число {solveelement} встречается {count} раз ");
            solveelement = newarray[i];
            count = 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"число {solveelement} встречается {count} раз ");
}
