// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// 1 способ переворот

int[] GetArray(int size, int minValue, int MaxValue)
{
    int[]res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i]=new Random().Next(minValue,MaxValue);
    }
    return res;
}

void ReverseArray1(int[]inArray)
{
    for(int i=0; i<inArray.Length/2; i++)
    {
        int k = inArray[i];
        inArray[i]=inArray[inArray.Length - 1 -i];
        inArray[inArray.Length - 1 -i] = k;
    }
}

int[] ReverseArray2(int[]inArray)
{
    int[]result = new int [inArray.Length];
    for(int i=0; i<inArray.Length; i++)
    {
        result[i]=inArray[inArray.Length-1-i];
    }
    return result;
}

int[]array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine();
// ReverseArray1(array);
// Console.WriteLine(string.Join(" ", array));
int[] reversArray = ReverseArray2(array);
Console.WriteLine(string.Join(" ", reversArray));