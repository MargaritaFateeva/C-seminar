// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] GetNewArray1 (int[]array)
{
    int n = array.Length/2;
    int[] arr = new int[n];
    for (int i=0; i<n; i++)
    {
        arr[i]=array[i]*array[array.Length-i-1];
    }
    return arr;
}

int[] GetNewArray2 (int[]array)
{
    int n = array.Length/2+1;
    int[] arr = new int[n];
    for (int i=0; i<n; i++)
    {
        arr[i]=array[i]*array[array.Length-i-1];
        arr[n-1]=array[n-1];
    }
    return arr;
}

Console.WriteLine("Введите длину массива");
int m = int.Parse(Console.ReadLine());
int[] arr1 = GetArray(m);
PrintArray(arr1);
Console.WriteLine();

if (m%2 ==0) PrintArray(GetNewArray1(arr1));
else PrintArray(GetNewArray2(arr1));