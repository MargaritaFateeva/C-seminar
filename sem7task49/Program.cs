// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты. Например, изначально 
// массив выглядел вот так: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 

// Новый массив будет выглядеть вот так: 
// 1 4 49 2 
// 5 9 4 9 
// 64 4 4 4

int[,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
        matrix[rows, columns] = new Random().Next(1,10);
        }
    }
    return matrix;
}

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i, j]} ");
}
Console.WriteLine();
}
}

int[,] MultiEvenIndex(int[,] array)
{
    
for (int j = 0; j < array.GetLength(1); j++)
{
for (int i = 0; i < array.GetLength(0); i++)
{
if(i%2==0 && j%2==0) array[i,j]= array[i, j]*array[i,j];
}
}
return (array);
}

int[,] arr = CreateArray(3,4);
PrintArray(arr);
Console.WriteLine();
PrintArray(MultiEvenIndex(arr));
