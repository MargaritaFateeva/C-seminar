// Задача 4: Напишите программу, которая принимает на вход три числа и выдает 
// максимальное из этих чисел.
// 2, 3, 7 -> 7 
// 44 5 78 -> 78 
// 22 3 9 -> 22

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (max>b)
{
Console.WriteLine("Max 1 число " + max);
    }
else
{
    max=b;
    Console.WriteLine("Max 2 число " + max);
}
    if (max>c)
    {
    Console.WriteLine("Max 1 число " + max);
    }
    else
    {  
        max=c;
        Console.WriteLine("Max 3 число " + max);
    }
   
Console.Write("Max " + max);