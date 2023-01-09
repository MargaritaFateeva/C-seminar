// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите количество строк массива X: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива Y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите количество слоев массива Z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,,] GetArray3d (int x, int y, int z) // создание 3-мерного массива
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void PrintArray3d (int[,,] inArray) // вывод 3-мерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }   
    }
}

int[] CreateSingleArray(int[,,] inArray) // 3-мерную матрицу записываем в одномерный массив
{
    int n = 0;
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)*inArray.GetLength(2)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                result[n] = inArray[i, j, k];
                //Console.Write(result[n] + " "); // вывод для проверки
                n++;
            }
        }
    }
    // Console.WriteLine();
    return result;
}

int[] SortArray(int[] inArray) // сортировка по возрастанию одномерного массива
{
    Array.Sort(inArray);
    // for (int i = 0; i < inArray.Length; i++) // вывод для проверки
    // {
    //     Console.Write($"{inArray[i]} ");
    // }
    return inArray;
}

int FindRepeatElement (int[] inArray) // поиск значения первого повторяющегося элемента
{
    int repeat = 0;
    for (int i=0; i<inArray.Length-1; i++)
    {
        if (inArray[i]==inArray[i+1]) 
        {
            repeat = inArray[i];
            break;
        }
        else if (inArray[i]<inArray[i+1]) repeat = 0;
        else repeat = 0;       
    }
    return repeat;
}

int [,,] ChangeRepeatElements (int [,,] inArray, int repeat) // замена повторяющихся элементов
{
    int repeatEl = repeat;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                if (repeatEl==0) break;
                if (inArray[i,j,k]==repeatEl) 
                {
                    inArray[i,j,k] = new Random().Next(10, 100);
                    break;
                }
            }
        }
    }
    return inArray;
}

int[,,] array = GetArray3d(x, y, z);
// PrintArray3d(array); // вывод для проверки
// Console.WriteLine();
int [] singlesort = SortArray(CreateSingleArray(array));
// Console.WriteLine();
int repeatElem = FindRepeatElement (singlesort);
// Console.WriteLine (FindRepeatElement (singlesort)); // вывод для проверки
// Console.WriteLine();
int[,,] newarr = ChangeRepeatElements(array, repeatElem);
// PrintArray3d(newarr); // вывод для проверки

while (repeatElem!=0)
{
    singlesort = SortArray(CreateSingleArray(newarr));
    // Console.WriteLine();
    repeatElem = FindRepeatElement (singlesort);
    // Console.WriteLine (FindRepeatElement (singlesort)); // вывод для проверки
    // Console.WriteLine();
    newarr = ChangeRepeatElements(newarr, repeatElem);
    // PrintArray3d(newarr); // вывод для проверки
}
PrintArray3d(newarr);