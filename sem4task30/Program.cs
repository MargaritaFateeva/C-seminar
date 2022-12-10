// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

 Console.Write("Введите число: ");
 int num = int.Parse(Console.ReadLine());
 int[]arr = new int[num];
//  Console.Write($"Массив = {GetArrayRandom01 (num)}");

 void GetArrayRandom01 (int[]N)
 {
     int lenght = N.Length;
     int i = 0;

     while (i<lenght)
     {
         N[i] = new Random().Next(0,2);
         i++;
    }
}

void GetPasteArray (int[]NN)
{
    int leng = NN.Length;
    int count=0;
    while (count<leng)
    {
        Console.Write($" {NN[count]} ");
        count++;
    }
}
GetArrayRandom01(arr);
GetPasteArray(arr);

// int n = 8;
// int[] arr = new int[n];
// Random rand = new Random();
// int[] GetNewArr(int[]arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = rand.Next(0,2);
//             Console.Write(arr[i]+" ");
//         }
//     return arr;
// }
// GetNewArr(arr);