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

int max = 0;

if (a>=b) // = для случая когда максимальные a=b (2 2 1)
{
    max = a;
}
if (a<b)
{
    max = b;
}

if (max>=c) // = для случая когда 2 максимальных равны (2 1 2 или 1 2 2)
{
            //  пустой, тк оставляем как есть присвоение max=max
}
if (max<c)
{  
    max = c;
}

Console.Write("Max " + max);