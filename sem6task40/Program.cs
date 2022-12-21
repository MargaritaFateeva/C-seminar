// Задача 40:
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите 3 числа, после каждого нажать ВВОД");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
 
 void Check(int a, int b, int c)
 {
    bool yes=true;
    if(a>b+c || b>a+c || c>b+a) yes=false;
    // if(a>b+c) yes=false;
    // if(b>a+c) yes=false;
    // if(c>b+a) yes=false;
    if (yes==true) Console.WriteLine("Треугольник возможен");
    if (yes==false) Console.WriteLine("Треугольник невозможен");
 }

 Check(a,b,c);