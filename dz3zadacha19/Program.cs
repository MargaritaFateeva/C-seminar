// Задача 19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int num = N;
int number = N;
int count = 0;

while (number>0)
{
    number=number/10;
    count++;
}
Console.WriteLine($"Число N {count}-значное");

int i = 1;

while (N>0)   
{
    double a = Math.Pow(10,1);
    double b = Math.Pow(10,count-i);

    int first = (int)b;
    int last = (int)a;

    int c = N/first;
    int d = N%last;
    if (c==d)
    {
        Console.WriteLine($"число {i}={c} совпадает c число {count} = {d}");    
        N = (N - c*first)/10;
        Console.WriteLine($"Новое число N = {N}");
        if (N==0)  
        {
            Console.WriteLine($"Число {num} является палиндромом ");
            break;
        }     
    }
    count =count-2;

    if (c>d || c<d)
    {
    Console.WriteLine($"число {i}={c} не совпадает с числом {count} = {d}");
    Console.WriteLine($"Число {num} не является палиндромом ");
    break;
    }
} 
    

