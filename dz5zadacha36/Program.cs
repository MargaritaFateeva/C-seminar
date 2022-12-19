// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[]array = new int[4];

void FillArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=new Random().Next(-100,100);
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

int GetSumOddElement(int[]arr)
{
    int sum = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (i%2==0) sum=sum;
        else sum=sum+arr[i];
    }
    return sum;
}

FillArray(array);
PrintArray(array);
int result = GetSumOddElement(array);
Console.Write($"Сумма нечетных элементов массива -> {result}");