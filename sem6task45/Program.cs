// Задача 45:
// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] CreateArray()
{
    int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"Введите {i+1} элемента массива:");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine(string.Join(" ", array));
    return array;
}

void NewArray(int[] Array)
{
    int[] newarr = new int[Array.Length];
    for (int i = 0; i < newarr.Length; i++)
    {
        newarr[i] = Array[i];
        Console.Write($"{newarr[i]} ");
    }
}

NewArray(CreateArray());