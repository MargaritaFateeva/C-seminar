// Задача №14. Работа в группах Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23. 
// ●14 -> нет ●46 -> нет ●161 -> да

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int ost7 = N%7;
int ost23 = N%23;

if (ost7==0)
{
    if (ost23==0)
    {
        Console.WriteLine($"{N} -> да");
    }
    else
    {
        Console.WriteLine($"{N} -> нет");
    }
}
else
{
    Console.WriteLine($"{N} -> нет");
}