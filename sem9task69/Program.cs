// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// int Degree(int a, int b)
// {
//     if (b==0) return 1;
//     else return a*Degree(a,b-1);
// }

double Degree(double a, double b)
{
    if (b==0) return 1;
    else if (b<0) return (1/a)*Degree(a,b+1);
    else return a*Degree(a,b-1);
}

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{Degree(a, b)}");







