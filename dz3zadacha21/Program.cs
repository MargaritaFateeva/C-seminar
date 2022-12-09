// Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Точка A введите координату X: ");
int Xa = int.Parse(Console.ReadLine());
Console.Write("Точка А введите координату Y: ");
int Ya = int.Parse(Console.ReadLine());
Console.Write("Точка А введите координату Z: ");
int Za = int.Parse(Console.ReadLine());

Console.Write("Точка B введите координату X: ");
int Xb = int.Parse(Console.ReadLine());
Console.Write("Точка B введите координату Y: ");
int Yb = int.Parse(Console.ReadLine());
Console.Write("Точка А введите координату Z: ");
int Zb = int.Parse(Console.ReadLine());

double d = Math.Sqrt ((Xb-Xa)*(Xb-Xa) + (Yb-Ya)*(Yb-Ya) + (Zb-Za)*(Zb-Za));
Console.Write($"Расстояние между двумя точками A и B: {d}");