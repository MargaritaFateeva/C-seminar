// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size)
{
    int[]res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i]=new Random().Next(-10,11);
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

void GetChangeElement(int[] arr)
{
    Console.Write($"-> ");
    for(int i=0; i<arr.Length; i++)
    {
        arr[i]=arr[i]*(-1);
        Console.Write($" {arr[i]} ");
    }
}

int [] array = GetArray(4);
PrintArray(array);
Console.WriteLine();

GetChangeElement(array);
