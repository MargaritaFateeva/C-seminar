// Задача 44:
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5--> 0 1 1 2 3
// Если N = 3--> 0 1 1
// Если N = 7--> 0 1 1 2 3 5 8

int[] Fibonacci (int n)
{
    int[]fib = new int[n];
    for (int i=2; i<n; i++)
    {
        fib[0]=0;
        fib[1]=1;
        fib[i]= fib[i-1]+fib[i-2]; 
    }
    Console.WriteLine(string.Join(" ", fib));
    return fib;
}

Fibonacci(7);
