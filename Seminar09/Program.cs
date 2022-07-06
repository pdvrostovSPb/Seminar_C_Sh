/* void Rec(int n)
{
    if (n == 0)
    {
            return;
    }    
    
    Rec(n - 1);
    Console.Write(" " + n);
}


Rec(5); */
 

 /* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */


/* void Rec(int n, int m)
{
    if (n < m)
    {
            return;
    }    
    
    Rec((n - 1),m);
    Console.Write(" " + n);
}

int M = 75, N = 85;

Rec(N, M); */

/* Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

/* int Rec(int n)
{
    if (n == 0)
    {
        return 0;
    }    
    
    return n % 10 + Rec(n / 10);
}


Console.WriteLine (Rec(453)); */

/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int Rec(int n, int m)
{
    if (m == 0)
    {
        return 1;
    }    
    return Rec(n, m - 1) * n;
}

int A = 2, B = 10;

Console.WriteLine(Rec(A, B));