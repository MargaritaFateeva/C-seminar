// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении 
// сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size)
{
    int[]res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i]=new Random().Next(-500,500);
    }
    return res;
}

void PrintArray(int[]arr)
{
    for(int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
} 

int GetCountNumbers(int[]arr, int minValue, int maxValue)
{
    int count = 0;
    for (int i =0; i<arr.Length; i++)
    {
        if ((arr[i]>minValue-1) && (arr[i]<maxValue+1)) count=count+1;
        else count=count;
    }
    return count;
}

int[] array = GetArray(123);
PrintArray(array);
Console.WriteLine();
Console.Write($"Количество элементов [{10};{99}]");
Console.Write($" -> {GetCountNumbers(array, 10, 99)}");