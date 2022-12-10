// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2, 5, 7, 19, 6, 1, 33]

int[]array = new int [] {1, 2, 5, 7, 19, 6, 1, 33};


 void FillArray (int[]collection)
 {
     int lenght = collection.Length;
     int index = 0;
     while (index<lenght)
     {
         collection[index]=new Random().Next(0,100);
        index++;
    }
}

void PrintArray(int[]collect)
{
    int count=collect.Length;
    int position=0;
    Console.Write("-> [");
    while (position<count-1)
    {
        Console.Write($" {collect[position]}, ");
        position++;
    }
     while (position<count && (position>count-2)) 
    {
        Console.Write($" {collect[position]}");
        position++;
    }
    Console.Write($"]");
}

//FillArray(array); // это не нужно - перезаписала массив входной  случайным образом
//Console.Write($"{array}, ");  // не разобралась как вывести входной массив выводит System.Int32[]
PrintArray(array);
