// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[]arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(100,1000);
    }
}

void PrintArray(int[]arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenNumber (int[]arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2==0) count++;
        else count=count;
    }
    return count;
}

int[] array = new int[10];

PrintArray(array);
FillArray(array);
PrintArray(array);

int result = CountEvenNumber(array);
Console.Write($"Четных чисел в массиве -> {result}");
