// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45--> 101101
// 3--> 11
// 2--> 10

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
int begin = n;
int res=n;
string numDouble = "";
while (n>0)
{
    res=n%2;
    numDouble = res+numDouble;
    n=n/2;
}
Console.WriteLine($"Число {begin} в двоичной системе -> {numDouble}");