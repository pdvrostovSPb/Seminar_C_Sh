/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
M = 8; N = 4. -> "8, 7, 6, 5, 4" */

/* int Rec(int a, int b)
{
    if (a == b)
    {
        Console.Write(b);
        return b;
    }
    if (a < b)
    {
        Console.Write(a + " ");
        Rec((a + 1), b);
    }
    else
    {
        Console.Write(a + " ");
        Rec((a - 1), b);
    }
    return b;
}
int M = 3, N = 9;
Rec(M, N); */


////////////////////////////////////////////////////////////

/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/* int Sum(int a, int b)
{
    if (a == b) return a;
    {
        return Sum(a + 1, b) + a;
    }
}
int M = 4; int N = 8;
Console.WriteLine(Sum(M, N)); */

///////////////////////////////////////////////////////////

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */

/* int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return 0;
}

Console.WriteLine(Akkerman(3,2)); */
