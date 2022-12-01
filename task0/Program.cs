//Напишите программу, которая на вход принимает число и выдает его квадрат 
//(число умноженное на само себя). 
//Например: ●4 -> 16 ●-3 -> 9 ●-7 -> 49

Console.Write("ВВедите число: ");
int number = int.Parse(Console.ReadLine());
int sqrt = number*number;
Console.WriteLine("Квадрат числа = " + sqrt);