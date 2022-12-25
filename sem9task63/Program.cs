//ВАРИАНТ ВЫВОДА ЧЕРЕЗ СТРОЧНЫЙ МАССИВ
string LineNumbers(int n)
{
return (n>=2) ? LineNumbers(n-1) + $" {n}" : "1";

// if(n>=2) 
// {
//    return LineNumbers(n-1) + $" {n}";
// }
// else
// {
// return "1";
// }

}
Console.WriteLine(LineNumbers(10));




//ВАРИАНТ ВЫВОДА VOID
void LineNumbers2(int n)
{
    if(n != 1) LineNumbers2(n - 1);
    Console.Write($"{n} ");
}
LineNumbers2(5);

