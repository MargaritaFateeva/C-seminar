// Задача №3. Напишите программу, которая будет выдавать название дня недели 
// по заданному номеру. 3 -> Среда 5 -> Пятница
// числа задаются случайным образом и вывод 5 строк - 5 чисел

int count = 0;

while (count<5)
{

int number = new Random().Next(1,10);

Console.WriteLine("Введите число: " + number);


if (number==1)
{
    Console.WriteLine("Понедельник");
    }
if (number==2)
{
    Console.WriteLine("Вторник");
    }  
if (number==3)
{
    Console.WriteLine("Среда");
    }     
if (number==4)
{
    Console.WriteLine("Четверг");
    }  
if (number==5)
{
    Console.WriteLine("Пятница");
    }
if (number==6)
{
    Console.WriteLine("Суббота");
    }   
if (number==7)
{
    Console.WriteLine("Воскресенье");
    }  
if (number<1)
{
    Console.WriteLine("Некорректное число");
    }    
if (number>7)
{
    Console.WriteLine("Некорректное число");
    }       
count++;
}