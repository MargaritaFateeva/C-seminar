// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int [] array = new int[20];
int count = 0;
Console.WriteLine("Введите число вводимых элементов");
int n = int.Parse(Console.ReadLine());

int GetCreateArray(int m)
{
    for (int i=0; i<m; i++)
    {
        Console.WriteLine("Введите число");
        array[i] = int.Parse(Console.ReadLine());
        count++; 
    }
    Console.WriteLine(string.Join(" ", array));
    return count;
}

int[] CreateNewArray(int n, int[]array)
{
    int[]arr = new int[n];
    for (int i=0; i<n; i++)
    {
        arr[i]=array[i];
    }
    Console.WriteLine(string.Join(" ", arr));
    return arr;
}

void CountPositiveNums (int[] arr)
{
    int count=0;
    foreach (int el in arr)
    {
        if (el>0) count++;
        else count=count;
    }
Console.Write($"Число введенных элементов больше 0 -> {count}");
}

GetCreateArray(n);
int[]newarr = CreateNewArray(n,array);
CountPositiveNums(newarr);
