// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetArray(int size)
{
    int[]res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i]=new Random().Next(0,11);
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

void FindNumber(int[]arr, int n)
{
    int count = 0;
    for (int i=0; i<arr.Length;i++)
    {
        if (n==arr[i]) count = count+1;  
    }
    int res=count;
    if (res>0) Console.WriteLine(" -> да");
    else Console.Write(" -> нет");
}

int[]array = GetArray(10);
PrintArray(array);
FindNumber(array, 2);
