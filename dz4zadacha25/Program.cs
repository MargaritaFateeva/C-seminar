// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"число {a} в степени {b} = {(double)GetMinusDegrNum(a,b)}"); //обращение к методу

int GetDegrNum (int num, int deg) // метод для натуральных степеней и 0
{
    int pow=1;
    double pow1=1;
    int i=1;
    int j=1;
    if (deg>0)
    {
        while (i<=deg)
        {
            pow=num*pow;
            i++;
        }
    }    
    
    if (deg==0)
    {
        pow=1;
    }
    if (deg<0)
    {
        Console.WriteLine("Введите степень больше 0");
    }
    return pow;
}

double GetMinusDegrNum (int number, int minusdeg) // метод для отрицательных степеней
{
    double pow1=1.0;  
    int j=1;
    double doblnumber = (double)number;
    if (minusdeg<0)
    {
        while (-j>=minusdeg)
        {
        pow1=pow1*(1/doblnumber);
        j++;
        }
    }
    if (minusdeg>=0)
    {
        int getplusdeg = GetDegrNum (number,minusdeg);
        pow1 = (double)getplusdeg;
    }
    return pow1;
}    